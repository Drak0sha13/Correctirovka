DxBlazorInternal.define("cjs-checkbox-f09a744f.js",function(n,e,c){n("./cjs-chunk-9eab2df8.js");var t=n("./cjs-dom-utils-9e3f000c.js");function i(n,e,c,i,a){if(n=t.EnsureElement(n)){n.indeterminate=c;var f=function(n,e){return e?0:n?1:2}(e,c),s=e;n.onchange=function(e){i?(function(n,e){var c=!1,t=!1;0===e?c=!0:1===e&&(t=!0);n.indeterminate=c,n.checked=t}(n,f=(f+1)%3),s=function(n){return 0===n?null:1===n}(f)):s=!s,a.invokeMethodAsync("RaiseCheckedChanged",s)}}}var a={Init:i};c.Init=i,c.default=a},["cjs-chunk-9eab2df8.js","cjs-dom-utils-9e3f000c.js"]);
