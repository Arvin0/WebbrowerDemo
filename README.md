# 项目说明
winform + webbrower 使用探索


## winform 与 webbrower交互
* winfom 向 webbrower 传递数据  
	直接调用页面中的js方法
* webbrower 向 winform 传递数据  
   需要先在winform中设置便签事件；事件触发后调用winform中的方法，然后再调用页面中的js来获取相应的数据
* webbrower 调用服务端接口  
	webbrower中可以直接通过ajax访问web api接口；不需要中转到form, 从form中访问接口；  
	>注意点：  
	服务端：开启跨域访问  
	ajax中添加如下设置：
	```
	全局添加：$.support.cors = true; //跨域请求设置
	ajax方法中添加：crossDomain: true  
	如果是非get请求，还需添加：contentType: 'application/json'， 并且数据需要使用【JSON.stringify】转换
	```
	
* winform 调用 页面js
	```
	HtmlDocument htmlDoc = this.webBrowser_vteshow.Document;
	HtmlElement btnshowTransferDataInForm = htmlDoc.All["showTransferDataInForm"];
	if (btnshowTransferDataInForm != null)
	{
		// 点击页面按钮，从页面中获取数据
		// HtmlElement提供了一些常用事件如Click；没有提供的事件可以使用AttachEventHandler来执行
		// btnshowTransferDataInForm.Click += new HtmlElementEventHandler(TransferDataToFormParam);
		btnshowTransferDataInForm.AttachEventHandler("onclick", new EventHandler(TransferDataToFormParam));
	}
	
	private void TransferDataToFormParam(object sender, EventArgs e)
	{
		// 执行页面中的js方法，获取页面数据
		var result = this.webBrowser_vteshow.Document.InvokeScript("transferDataToForm");
		this.rtBox_aishow.Text = result.ToString();
	}
	```