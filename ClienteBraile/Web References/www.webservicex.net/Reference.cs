// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ClienteBraile.www.webservicex.net {
    
    
    /// <remarks/>
    [System.Web.Services.WebServiceBinding(Name="BrailleSoap", Namespace="http://www.webserviceX.NET")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Braille : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback BrailleTextOperationCompleted;
        
        public Braille() {
            this.Url = "http://www.webservicex.net/braille.asmx";
        }
        
        public Braille(string url) {
            this.Url = url;
        }
        
        public event BrailleTextCompletedEventHandler BrailleTextCompleted;
        
        /// <remarks>
///Convert TEXT to Braille
///</remarks>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/BrailleText", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public byte[] BrailleText(string InText, float TextFontSize) {
            object[] results = this.Invoke("BrailleText", new object[] {
                        InText,
                        TextFontSize});
            return ((byte[])(results[0]));
        }
        
        public System.IAsyncResult BeginBrailleText(string InText, float TextFontSize, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("BrailleText", new object[] {
                        InText,
                        TextFontSize}, callback, asyncState);
        }
        
        public byte[] EndBrailleText(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((byte[])(results[0]));
        }
        
        public void BrailleTextAsync(string InText, float TextFontSize) {
            this.BrailleTextAsync(InText, TextFontSize, null);
        }
        
        public void BrailleTextAsync(string InText, float TextFontSize, object userState) {
            if ((this.BrailleTextOperationCompleted == null)) {
                this.BrailleTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrailleTextCompleted);
            }
            this.InvokeAsync("BrailleText", new object[] {
                        InText,
                        TextFontSize}, this.BrailleTextOperationCompleted, userState);
        }
        
        private void OnBrailleTextCompleted(object arg) {
            if ((this.BrailleTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrailleTextCompleted(this, new BrailleTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    }
    
    public partial class BrailleTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BrailleTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    public delegate void BrailleTextCompletedEventHandler(object sender, BrailleTextCompletedEventArgs args);
}