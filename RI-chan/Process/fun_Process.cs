using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks;
using CuoreUI.Controls;
using RI_chan.Langs;
using SiticoneNetCoreUI;

namespace RI_chan.Process
{
    public class fun_Process
    {
        #region VAR

        #endregion

















        #region FUN
        public async Task<string?> GetFastbootDeviceAsync()
        {
            string fastbootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "platform_tools", "fastboot.exe");

            if (!File.Exists(fastbootPath))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = fastbootPath,
                    Arguments = "devices",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                var process = new System.Diagnostics.Process { StartInfo = processStartInfo };
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();
                await process.WaitForExitAsync();

                if (!string.IsNullOrWhiteSpace(error))
                {
                    MessageBox.Show(Lang.FastbootError + error, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length == 0)
                return null; 

                var parts = lines[0].Split('\t');
                return parts.Length > 0 ? parts[0] : null;     
        }


        public async Task<bool> ExtractAsync(string zipPath)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string pdgExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pdg", "payload-dumper-go.exe");
            string outputDir = Path.Combine(baseDir, "pdg", "output");
            string[] partitions = { "boot", "dtbo", "vendor_boot" };

            Directory.CreateDirectory(outputDir);

            if (!File.Exists(pdgExe))
            {
                MessageBox.Show(Lang.NotDumper, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Directory.CreateDirectory(outputDir);

            foreach (var part in partitions)
            {
                var psi = new ProcessStartInfo
                {
                    FileName = pdgExe,
                    Arguments = $"-o \"{outputDir}\" -p {part} \"{zipPath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new System.Diagnostics.Process { StartInfo = psi })
                {
                    process.Start();
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    await process.WaitForExitAsync();

                    if (process.ExitCode != 0)
                    {
                        throw new Exception($"Error al extraer {part}: {error}");
                    }
                    Console.WriteLine($"[{part}] {output}");
                }
            }
            return true;
        }
        public async Task<bool> FlashBootAsync()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fastbootExe = Path.Combine(baseDir, "platform_tools", "fastboot.exe");
            string bootImgPath = Path.Combine(baseDir, "pdg", "output", "boot.img");

            if (!File.Exists(fastbootExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(bootImgPath))
                throw new FileNotFoundException("File Not Found!", bootImgPath);

            var psi = new ProcessStartInfo
            {
                FileName = fastbootExe,
                Arguments = $"flash boot \"{bootImgPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0)
                {
                    MessageBox.Show(error);
                    Console.WriteLine($"Error flashing boot: {error}");
                    return false;
                }

                Console.WriteLine(output);
               
                return true;
            }
        }
        public async Task<bool> FlashDtboAsync()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fastbootExe = Path.Combine(baseDir, "platform_tools", "fastboot.exe");
            string dtboImgPath = Path.Combine(baseDir, "pdg", "output", "dtbo.img");

            if (!File.Exists(fastbootExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(dtboImgPath))
                throw new FileNotFoundException("File Not Found!", dtboImgPath);

            var psi = new ProcessStartInfo
            {
                FileName = fastbootExe,
                Arguments = $"flash dtbo \"{dtboImgPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"Error flashing dtbo: {error}");
                    return false;
                }

                Console.WriteLine(output);
                return true;
            }
        }
        public async Task<bool> FlashVendorBootAsync()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fastbootExe = Path.Combine(baseDir, "platform_tools", "fastboot.exe");
            string vendorBootImgPath = Path.Combine(baseDir, "pdg", "output", "vendor_boot.img");

            if (!File.Exists(fastbootExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(vendorBootImgPath))
                throw new FileNotFoundException("File Not Found!", vendorBootImgPath);

            var psi = new ProcessStartInfo
            {
                FileName = fastbootExe,
                Arguments = $"flash vendor_boot \"{vendorBootImgPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0 )
                {
                    Console.WriteLine($"Error flashing vendor_boot: {error}");
                    return false;
                }

                Console.WriteLine(output);
                return true;
            }
        }

        public async void RebootAsync()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fastbootExe = Path.Combine(baseDir, "platform_tools", "fastboot.exe");

            if (!File.Exists(fastbootExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var psi = new ProcessStartInfo
            {
                FileName = fastbootExe,
                Arguments = $"reboot recovery",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0 || !string.IsNullOrWhiteSpace(error))
                {
                    Console.WriteLine($"Error on command: {error}");
                }

                Console.WriteLine(output);
            }
        }
        public async Task<(bool found, string? deviceId)> GetAdbDeviceAsync()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string adbExe = Path.Combine(baseDir, "platform_tools", "adb.exe");

            if (!File.Exists(adbExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null);
            }

            var psi = new ProcessStartInfo
            {
                FileName = adbExe,
                Arguments = "devices",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0)
                    throw new Exception("Error adb devices command: " + error);

                var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {
                    if (line.Contains("\tsideload"))
                    {
                        var parts = line.Split('\t');
                        if (parts.Length > 0)
                            return (true, parts[0]);
                    }
                }

                return (false, null);
            }
        }

        public async Task<bool> SideloadingAsync(string zipPath, SiticoneHProgressBar progressBar)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string adbExe = Path.Combine(baseDir, "platform_tools", "adb.exe");

            if (!File.Exists(adbExe))
            {
                MessageBox.Show(Lang.NotPlatformTools, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(zipPath))
                throw new FileNotFoundException("No zip file ERROR!", zipPath);

            var psi = new ProcessStartInfo
            {
                FileName = adbExe,
                Arguments = $"sideload \"{zipPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = psi })
            {
                process.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        // Buscar porcentaje en la salida (ej: "serving: 'update.zip'  47%")
                        var match = Regex.Match(e.Data, @"(\d+)%");
                        if (match.Success && int.TryParse(match.Groups[1].Value, out int percent))
                        {
                            progressBar.Invoke((Action)(() =>
                            {
                                progressBar.Value = Math.Min(percent, progressBar.Maximum);
                            }));
                        }
                    }
                };

                process.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        throw new FileNotFoundException("flashing file ERROR!", zipPath);
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await process.WaitForExitAsync();

                progressBar.Invoke((Action)(() =>
                {
                    progressBar.Value = progressBar.Maximum;
                }));
                return process.ExitCode == 0;
            }
        }

        #endregion







    }
}
