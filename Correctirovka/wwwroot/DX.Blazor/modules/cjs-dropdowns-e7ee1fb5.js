DxBlazorInternal.define("cjs-dropdowns-e7ee1fb5.js",function(e,n,t){e("./cjs-chunk-9eab2df8.js");var o=e("./cjs-dom-utils-9e3f000c.js"),r=e("./cjs-chunk-f8581dee.js"),c=e("./cjs-chunk-ea895bfc.js"),s=e("./cjs-chunk-98cdd37b.js"),u=document.body,i={},a=[],l={subtree:!0,childList:!0},d=new MutationObserver(function(e,n){for(var t=0;t<e.length;t++)e[t].removedNodes.forEach(function(e){a.filter(function(n){return e===n.element}).map(function(e){return e.callback}).forEach(function(e){return e()})})});function f(e){return i[e]||(i[e]=new Promise(function(n,t){0===a.length&&d.observe(u,l),function(e,n){var t={element:e,callback:function(){a.splice(a.indexOf(t),1),delete i[e],0===a.length&&d.disconnect(),n()}};a.push(t)}(e,n)}))}var v={Popup:0,Modal:1};function m(e,n,t){for(var o=e.target;o;){if(o===n)return!1;o=o.parentElement}t&&t()}function E(e){return"none"!==e.style.display}var h="a[href], input:not([disabled]), button:not([disabled]), [tabindex]:not([tabindex='-1'])";var p={Init:function(e,n,t,s){if(e=o.EnsureElement(e),n=o.EnsureElement(n),t=o.EnsureElement(t),e){if(r.DisposeEvents(e),t){var u=function(c){return m(c,e,function(){o.elementIsInDOM(e)||r.DisposeEvents(e);var c=document.activeElement===n,u=t&&E(t);(c||u)&&s.invokeMethodAsync("OnDropDownLostFocus",n.value)})};o.AttachEventToElement(document,c.TouchUIHelper.touchMouseDownEventName,u),r.RegisterDisposableEvents(e,function(){o.DetachEventFromElement(document,c.TouchUIHelper.touchMouseDownEventName,u)})}return Promise.resolve("ok")}},Dispose:function(e){return(e=o.EnsureElement(e))&&r.DisposeEvents(e),Promise.resolve("ok")},ShowAdaptiveDropdown:function(e,n,t,r,u){e=o.EnsureElement(e);var i=o.GetParentByClassName(e,t),a=(i.querySelector("."+r),document.documentElement);n===v.Popup&&o.SetPositionOfDropDown(i,e);var l=!1;function d(t){(!e.contains(t.srcElement)||n===v.Modal&&e===t.srcElement)&&E()}function m(n){a.removeEventListener("focusin",m),null===n.relatedTarget&&n.target&&e.contains(n.target)&&n.target.focus()}function E(){l||(l=!0,p(),u.invokeMethodAsync("CloseDialog"))}function p(){a.removeEventListener(c.TouchUIHelper.touchMouseDownEventName,d)}function D(){var n=e.querySelector(h);n&&n.focus()}return a.addEventListener(c.TouchUIHelper.touchMouseDownEventName,d),e.addEventListener("keydown",function(e){e.keyCode===s.Key.Esc&&E()}),e.addEventListener("focusout",function(n){var t,o,r;l||(null===n.relatedTarget||e.contains(n.relatedTarget)?null===n.relatedTarget&&a.addEventListener("focusin",m):void((t=e.compareDocumentPosition(n.relatedTarget))&Node.DOCUMENT_POSITION_PRECEDING?(r=e.querySelectorAll(h),void((o=r[r.length-1])&&o.focus())):t&Node.DOCUMENT_POSITION_FOLLOWING&&D()))}),n===v.Modal&&e.addEventListener("touchmove",function(n){n.srcElement===e&&n.preventDefault()}),f(e).then(function(){p()}),o.changeDom(D),Promise.resolve()}};t.IsDropDownVisible=E,t.OnOutsideClick=m,t.default=p},["cjs-chunk-9eab2df8.js","cjs-dom-utils-9e3f000c.js","cjs-chunk-f8581dee.js","cjs-chunk-ea895bfc.js","cjs-chunk-98cdd37b.js"]);