using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CuoreUI.Controls;
using RI_chan.Langs;

namespace RI_chan.Main
{

    public class fun_Main
    {
        #region FUN
        public void SetLanguage(Type sourceType)
        {
            if (sourceType == null) throw new ArgumentNullException(nameof(sourceType));

            var targetProps = typeof(RI_chan.Langs.Lang)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.CanWrite)
                .ToDictionary(p => p.Name, p => p);

            var sourceProps = sourceType
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.CanRead);

            foreach (var sProp in sourceProps)
            {
                if (targetProps.TryGetValue(sProp.Name, out var tProp))
                {
                    var value = sProp.GetValue(null);
                    tProp.SetValue(null, value);
                }
            }

            var sourceFields = sourceType.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var sField in sourceFields)
            {
                if (targetProps.TryGetValue(sField.Name, out var tProp))
                {
                    var value = sField.GetValue(null);
                    tProp.SetValue(null, value);
                }
            }
        }
        public string? GetROMFile(cuiFileDropper dropper)
        {
            string url = dropper.FileNames?.FirstOrDefault() ?? dropper.FileName;
            if (string.IsNullOrWhiteSpace(url) || !File.Exists(url))
                return null;
            string extension = Path.GetExtension(url).ToLowerInvariant();
            if (extension != ".zip" && extension != ".zip")
            {
                MessageBox.Show(Lang.ErrorIncorrectFile, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return url;
        }

        public bool VerifyPayload(string url)
        {
            if (url !=null)
            {
                var file = ZipFile.OpenRead(url);
                return file.Entries.Any(entry =>
                entry.FullName.Equals("payload.bin", StringComparison.OrdinalIgnoreCase) ||
                entry.FullName.EndsWith("/payload.bin", StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                MessageBox.Show(Lang.NotFileSelected, "RI-Chan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion
    }
}
