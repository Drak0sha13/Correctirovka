DxBlazorInternal.define("cjs-chunk-d6ceb400.js",function(e,t,n){var a=e("./cjs-chunk-98cdd37b.js");function r(e){return e==a.Key.Tab||16<=e&&e<=20}n.KeyDown=function(e){r(e.keyCode)||(e.target.dataset.previousValue=e.target.value)},n.KeyUp=function(e){if(r(e.keyCode))return!1;var t=e.target;return!(t&&t.dataset.previousValue===e.target.value)}},["cjs-chunk-98cdd37b.js"]);
