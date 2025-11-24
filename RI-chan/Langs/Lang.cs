using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RI_chan.Langs
{
    public static class Lang
    {
        public static string MainTitle { get; set; }
        public static string ErrorIncorrectFile { get; set; }
        public static string DropperNormalContent { get; set; }
        public static string DropperHoverContent { get; set; }
        public static string DropperClickToUpload { get; set; }
        public static string NotFileSelected {  get; set; }
        public static string InfoText1 {  get; set; }
        public static string ExitConfirm { get; set; }
        public static string NotPlatformTools { get; set; }
        public static string FastbootError { get; set; }
        public static string NotDumper { get; set; }
        public static string DumperError { get; set; }
        public static string StepTitle1 { get; set; }
        public static string StepTitle2 { get; set; }
        public static string StepTitle3 { get; set; }
        public static string StepTitle4 { get; set; }
        public static string StepTitle5 { get; set; }
        public static string StepTitle6 { get; set; }
        public static string StepTitle7 { get; set; }
        public static string StepDone { get; set; }
        public static string InfoText2 { get; set; }
        public static string ErrorNoDevice { get; set; }
        public static string Error1 { get; set; }
        public static string ReloadButtonText { get; set; }
        public static string WaitingForSideload {  get; set; }
        public static string ThankYou { get; set; }
        public static string Finished {  get; set; }
        public static string AboutText1 {  get; set; }
        public static string AboutText2 { get; set; }
        public static string OCText { get; set; }
        public static string GoToStart { get; set; }
    }

    public static class ES
    {
        public static string MainTitle = "Pantalla Principal";
        public static string ErrorIncorrectFile = "Perdon onii-chan, no puedo recibir archivos que no sean de tipo zip.";
        public static string DropperNormalContent = "Arrastra el Archivo Aqui";
        public static string DropperHoverContent = "Suelta el Archivo";
        public static string DropperClickToUpload = "Click para Buscar UwU";
        public static string NotFileSelected = "No seleccionaste ningun archivo.";
        public static string InfoText1 = "Ri-chan te ayudara a instalar una custom rom... \n\r Selecciona el archivo .zip";
        public static string ExitConfirm = "Seguro que te vas...?";
        public static string NotPlatformTools = "Disculpa, no pude encontrar la carpeta platform_tools en su sitio. No puedo continuar...";
        public static string FastbootError = "Oh no.! Hubo un error con fastboot y es el siguiente: ";
        public static string NotDumper = "Disculpa, no pude encontrar la carpeta dpg en su sitio. No puedo continuar...";
        public static string DumperError = "NOO.! Tenemos un problema con Payload Dumper Go. Paso esto:  ";
        public static string StepTitle1 = "Paso 1: Leyendo Dispositivo...";
        public static string StepTitle2 = "Paso 2: Obteniendo Imgs...";
        public static string StepTitle3 = "Paso 3: Flasheando Boot...";
        public static string StepTitle4 = "Paso 4: Flasehando Dtbo...";
        public static string StepTitle5 = "Paso 5: Flasehando Vendor_Boot...";
        public static string StepTitle6 = "Paso 6: Detectando Sideload.";
        public static string StepTitle7 = "Paso 7: Instalando ROM...";
        public static string StepDone = "Listo.";
        public static string InfoText2 = "Ri-chan intentara hacer esta parte por ti...";
        public static string ErrorNoDevice = "Lo siento, no pude detectar tu dispositivo.";
        public static string Error1 = "Parece que hubo un problema y no podre continuar T-T";
        public static string ReloadButtonText = "Volver a Empezar";
        public static string WaitingForSideload = "No puedo hacerlo todo por ti.\r\nDebes colocar el dispositivo en modo\r\nADB Sideload\r\n\r\nY no voy a continuar hasta que lo hagas.";
        public static string ThankYou = "Bien hecho! Muchas Gracias... Ahora podemos continuar.";
        public static string Finished = "Parece que el proceso termino muy bien, recuerda que es recomendable realizar un FORMAT DATA antes de iniciar tu Custom Rom...";
        public static string AboutText1 = "Soy RI-chan, te ayudare a instalar una custom rom a traves de fastboot.";
        public static string AboutText2 = "RI-chan usa Payload-Dumper-Go y Android Platform Tools para analizar un archivo zip y servirte de 'I-nstaladora de R-oms'. Sigue sus instrucciones y recuerda ser amable con ella.";
        public static string OCText = "Otros Creditos:";
        public static string GoToStart = "Volver al inicio";
    }
    public static class EN
    {
        public static string MainTitle = "Main Screen";
        public static string ErrorIncorrectFile = "Sorry onii-chan, I cannot accept files that are not of type zip.";
        public static string DropperNormalContent = "Drag the File Here";
        public static string DropperHoverContent = "Drop the File";
        public static string DropperClickToUpload = "Click to Browse UwU";
        public static string NotFileSelected = "You did not select any file.";
        public static string InfoText1 = "Ri-chan will help you install a custom ROM... \n\r Select the .zip file";
        public static string ExitConfirm = "Are you sure you want to leave...?";
        public static string NotPlatformTools = "Sorry, I could not find the platform_tools folder in its place. I cannot continue...";
        public static string FastbootError = "Oh no! There was an error with fastboot and it is the following: ";
        public static string NotDumper = "Sorry, I could not find the dpg folder in its place. I cannot continue...";
        public static string DumperError = "NOO! We have a problem with Payload Dumper Go. This happened: ";
        public static string StepTitle1 = "Step 1: Reading Device...";
        public static string StepTitle2 = "Step 2: Getting Imgs...";
        public static string StepTitle3 = "Step 3: Flashing Boot...";
        public static string StepTitle4 = "Step 4: Flashing Dtbo...";
        public static string StepTitle5 = "Step 5: Flashing Vendor_Boot...";
        public static string StepTitle6 = "Step 6: Detecting Sideload.";
        public static string StepTitle7 = "Step 7: Installing ROM...";
        public static string StepDone = "Done.";
        public static string InfoText2 = "Ri-chan will try to do this part for you...";
        public static string ErrorNoDevice = "Sorry, I could not detect your device.";
        public static string Error1 = "It seems there was a problem and I cannot continue T-T";
        public static string ReloadButtonText = "Start Over";
        public static string WaitingForSideload = "I cannot do everything for you.\r\nYou must put the device in\r\nADB Sideload mode\r\n\r\nAnd I will not continue until you do.";
        public static string ThankYou = "Well done! Thank you very much... Now we can continue.";
        public static string Finished = "It seems the process finished very well, remember it is recommended to perform a FORMAT DATA before starting your Custom ROM...";
        public static string AboutText1 = "I am RI-chan, I will help you install a custom ROM through fastboot.";
        public static string AboutText2 = "RI-chan uses Payload-Dumper-Go and Android Platform Tools to analyze a zip file and serve as your 'R-oms I-nstaller'. Follow her instructions and remember to be kind to her.";
        public static string OCText = "Other Credits:";
        public static string GoToStart = "Go to Start";
    }
}
