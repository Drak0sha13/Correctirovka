DxBlazorInternal.define("cjs-chunk-9eab2df8.js",function(o,e,r){var a={};function i(){if(document.compatible)for(var o=0;o<document.compatible.length;o++)if("IE"===document.compatible[o].userAgent&&document.compatible[o].version)return document.compatible[o].version.toLowerCase();return""}function n(o){var e=-1,r="";return o[1]&&(r+=o[1],o[2]&&(r+="."+o[2])),""!=r&&(e=parseFloat(r),isNaN(e)&&(e=-1)),e}function t(o,e){return n(new RegExp(e,"i").exec(o))+4}function d(o,e,r,a){var i=n(e);if(a){var d=t(o,r);if("edge"===a||parseInt(a)===d)return d}return i}function s(o,e,r,i,n){for(var t=0;t<o.length;t++){var d=o[t];a[d]=d==e}a.Version=Math.floor(10*r)/10,a.MajorVersion=Math.floor(a.Version),a.WindowsPlatform="Win"==i||"WinPhone"==i,a.MacOSPlatform="Mac"==i;var s="Mac"==i&&(!!window.ontouchstart||window.navigator.maxTouchPoints>0);a.MacOSMobilePlatform="MacMobile"==i||s,a.AndroidMobilePlatform="Android"==i,a.WindowsPhonePlatform="WinPhone"==i,a.WebKitFamily=a.Safari||a.Chrome||a.Opera&&a.MajorVersion>=15,a.NetscapeFamily=a.Netscape||a.Mozilla||a.Firefox,a.HardwareAcceleration=a.IE&&a.MajorVersion>=9||a.Firefox&&a.MajorVersion>=4||a.AndroidMobilePlatform&&a.Chrome||a.Chrome&&a.MajorVersion>=37||a.Safari&&!a.WindowsPlatform||a.Edge||a.Opera&&a.MajorVersion>=46,a.WebKitTouchUI=a.MacOSMobilePlatform||a.AndroidMobilePlatform;var c=a.IE&&a.MajorVersion>9&&a.WindowsPlatform&&a.UserAgent.toLowerCase().indexOf("touch")>=0;if(a.MSTouchUI=c||a.Edge&&!!window.navigator.maxTouchPoints,a.TouchUI=a.WebKitTouchUI||a.MSTouchUI,a.MobileUI=a.WebKitTouchUI||a.WindowsPhonePlatform,a.AndroidDefaultBrowser=a.AndroidMobilePlatform&&!a.Chrome,a.AndroidChromeBrowser=a.AndroidMobilePlatform&&a.Chrome,n&&(a.SamsungAndroidDevice=n),a.MSTouchUI){var l=a.UserAgent.toLowerCase().indexOf("arm;")>-1;a.VirtualKeyboardSupported=l||a.WindowsPhonePlatform}else a.VirtualKeyboardSupported=a.WebKitTouchUI;!function(o){for(var e="",r=o.concat(["WindowsPlatform","MacOSPlatform","MacOSMobilePlatform","AndroidMobilePlatform","WindowsPhonePlatform","WebKitFamily","WebKitTouchUI","MSTouchUI","TouchUI","AndroidDefaultBrowser","MobileUI"]),i=0;i<r.length;i++){var n=r[i];a[n]&&(e+="dx"+n+" ")}e+="dxBrowserVersion-"+a.MajorVersion,document&&document.documentElement&&(""!=document.documentElement.className&&(e=" "+e),document.documentElement.className+=e,a.Info=e)}(o)}a.UserAgent=navigator.userAgent.toLowerCase(),a.Mozilla=!1,a.IE=!1,a.Firefox=!1,a.Netscape=!1,a.Safari=!1,a.Chrome=!1,a.Opera=!1,a.Edge=!1,a.Version=void 0,a.MajorVersion=void 0,a.WindowsPlatform=!1,a.MacOSPlatform=!1,a.MacOSMobilePlatform=!1,a.AndroidMobilePlatform=!1,a.PlaformMajorVersion=!1,a.WindowsPhonePlatform=!1,a.AndroidDefaultBrowser=!1,a.AndroidChromeBrowser=!1,a.SamsungAndroidDevice=!1,a.WebKitTouchUI=!1,a.MSTouchUI=!1,a.TouchUI=!1,a.WebKitFamily=!1,a.NetscapeFamily=!1,a.HardwareAcceleration=!1,a.VirtualKeyboardSupported=!1,a.Info="",function(o,e){var r=["Mozilla","IE","Firefox","Netscape","Safari","Chrome","Opera","Opera10","Edge"],n={Safari:2,Chrome:.1,Mozilla:1.9,Netscape:8,Firefox:2,Opera:9,IE:6,Edge:12};if(!o||0==o.length)return s(r,"IE",n.IE,"Win"),void 0;!function(o){var e=/(?:(?:windows nt|macintosh|mac os|cpu os|cpu iphone os|android|windows phone|linux) )(\d+)(?:[-0-9_.])*/.exec(o);e&&(a.PlaformMajorVersion=e[1])}(o=o.toLowerCase());try{for(var c,l={Windows:"Win",Macintosh:"Mac","Mac OS":"Mac",Mac_PowerPC:"Mac","cpu os":"MacMobile","cpu iphone os":"MacMobile",Android:"Android","!Windows Phone":"WinPhone","!WPDesktop":"WinPhone","!ZuneWP":"WinPhone"},m="(?:"+(u="(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?")+")?",f={Safari:"applewebkit(?:.*?(?:version/"+u+"[\\.\\w\\d]*?(?:\\s+mobile/\\S*)?\\s+safari))?",Chrome:"(?:chrome|crios)(?!frame)(?:/|\\s*)?"+m,Mozilla:"mozilla(?:.*rv:"+m+".*Gecko)?",Netscape:"(?:netscape|navigator)\\d*/?\\s*"+m,Firefox:"firefox(?:/|\\s*)?"+m,Opera:"(?:opera|sopr)(?:/|\\s*)?"+m,Opera10:"opera.*\\s*version(?:/|\\s*)?"+m,IE:"msie\\s*"+m,Edge:"edge(?:/|\\s*)?"+m},u=-1,M=0;M<r.length;M++){var h=r[M],p=new RegExp(f[h],"i");if(p.compile&&p.compile(f[h],"i"),(g=p.exec(o))&&g.index>=0){if("IE"==c&&u>=11&&"Safari"==h)continue;"Opera10"==(c=h)&&(c="Opera"),u=d(o,g,"trident(?:/|\\s*)?"+m,i()),"Mozilla"==c&&u>=11&&(c="IE")}}c||(c="IE");var P,w=-1!=u;w||(u=n[c]);var b=Number.MAX_VALUE;for(var v in l)if(l.hasOwnProperty(v)){var I="!"==v.substr(0,1),W=o.indexOf((I?v.substr(1):v).toLowerCase());W>=0&&(W<b||I)&&(b=I?0:W,P=l[v])}var g,A=(g=o.toUpperCase().match("SM-[A-Z]"))&&g.length>0;"WinPhone"==P&&u<9&&(u=Math.floor(t(o,"trident(?:/|\\s*)?"+m))),!e&&"IE"==c&&u>7&&document.documentMode<u&&(u=document.documentMode),"WinPhone"==P&&(u=Math.max(9,u)),P||(P="Win"),P!=l["cpu os"]||w||(u=4),s(r,c,u,P,A)}catch(o){s(r,"IE",n.IE,"Win")}}(a.UserAgent),r.Browser=a},[]);
