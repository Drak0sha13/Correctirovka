DxBlazorInternal.define("cjs-combobox-292ccc6e.js",function(e,t,n){e("./cjs-chunk-9eab2df8.js");var o=e("./cjs-dom-utils-9e3f000c.js"),s=e("./cjs-chunk-f8581dee.js"),c=e("./cjs-chunk-ea895bfc.js"),r=e("./cjs-chunk-98cdd37b.js"),u=e("./cjs-dropdowns-e7ee1fb5.js");e("./cjs-chunk-e26655d2.js");var a=e("./cjs-chunk-f4c68e62.js"),i=e("./cjs-chunk-d6ceb400.js"),d=200,l=d/2;function m(e){var t=p(e);a.ScrollToSelectedItem(t)}function f(e){e=o.EnsureElement(e),document.activeElement===e&&v(e)}function E(e,t){e.dataset.timerId&&(clearTimeout(e.dataset.timerId),delete e.dataset.timerId),t||window.setTimeout(function(){E(e,!0)},l)}function v(e){e&&e.dataset.focusedClass&&(e.className=e.dataset.focusedClass)}function y(e,t){return t&&i.KeyDown(e),function(e){return h(e)}(e)&&(e.stopPropagation(),e.preventDefault()),!1}function j(e,t,n,o){var s=!1;if(o&&(s=s||i.KeyUp(e)),s=s||function(e){var t=e.altKey&&(e.keyCode==r.Key.Down||e.keyCode==r.Key.Up),n=h(e),o=e.keyCode==r.Key.Esc||e.keyCode==r.Key.Enter;return t||n||o}(e)){var c=e.target.value;if(n&&a.HasParametersForVirtualScrollingRequest(n)){var u=a.GetParametersForVirtualScrollingRequest(n,!1);t.invokeMethodAsync("OnComboBoxListBoxKeyUp",c,e.keyCode,e.altKey,e.ctrlKey,u.itemHeight,u.scrollTopForRequest,u.scrollHeightForRequest)}else t.invokeMethodAsync("OnComboBoxKeyUp",c,e.keyCode,e.altKey,e.ctrlKey)}}function h(e){return e.keyCode===r.Key.Down||e.keyCode===r.Key.Up||e.keyCode===r.Key.PageUp||e.keyCode===r.Key.PageDown||e.ctrlKey&&(e.keyCode===r.Key.Home||e.keyCode===r.Key.End)}function k(e,t,n){if(t){var o=(new Date).getTime();t.dataset.lastLostFocusTime&&o-t.dataset.lastLostFocusTime<d+100&&!n||(t.dataset.lastLostFocusTime=(new Date).getTime(),e.invokeMethodAsync("OnComboBoxLostFocus",t.value))}}function p(e){return(e=o.EnsureElement(e)).querySelector("div.dxbs-dm.dropdown-menu")}function D(e,t,n,r,a){if(e=o.EnsureElement(e)){s.DisposeEvents(e),r="true"===r.toLowerCase(),a="true"===a.toLowerCase(),t=o.EnsureElement(t);var i=p(e);o.SetPositionOfDropDown(e,i);var l=i;a&&m(e);var f=function(e){return y(e,r)},h=function(e){return j(e,n,l,r)},D=function(e){return function(e,t){v(e.target)}(e)},w=function(e){return function(e,t){var n=e.target;E(n,!0),n.dataset.timerId=window.setTimeout(function(){if(delete n.dataset.timerId,function(e){e&&e.dataset.bluredClass&&(e.className=e.dataset.bluredClass)}(n),document.activeElement!==n)try{k(t,n)}catch(e){}},d)}(e,n)},b=function(e){return E(t)},C=function(c){return u.OnOutsideClick(c,e,function(){o.elementIsInDOM(e)||s.DisposeEvents(e);var c=document.activeElement===t,r=t.dataset.timerId>0,a=i&&u.IsDropDownVisible(i);E(t),(c||r||a)&&k(n,t,!0)})};return o.AttachEventToElement(t,"keydown",f),o.AttachEventToElement(t,"keyup",h),o.AttachEventToElement(t,"focus",D),o.AttachEventToElement(t,"blur",w),o.AttachEventToElement(e,"mousedown",b),o.AttachEventToElement(document,c.TouchUIHelper.touchMouseDownEventName,C),s.RegisterDisposableEvents(e,function(){o.DetachEventFromElement(t,"keydown",f),o.DetachEventFromElement(t,"keyup",h),o.DetachEventFromElement(t,"focus",D),o.DetachEventFromElement(t,"blur",w),o.DetachEventFromElement(e,"mousedown",b),o.DetachEventFromElement(document,c.TouchUIHelper.touchMouseDownEventName,C)}),Promise.resolve("ok")}}function w(e){if(e=o.EnsureElement(e))return s.DisposeEvents(e),Promise.resolve("ok")}var b={Init:D,Dispose:w,PrepareInputIfFocused:f,ScrollToSelectedItem:m};n.Dispose=w,n.Init=D,n.PrepareInputIfFocused=f,n.ScrollToSelectedItem=m,n.default=b},["cjs-chunk-9eab2df8.js","cjs-dom-utils-9e3f000c.js","cjs-chunk-f8581dee.js","cjs-chunk-ea895bfc.js","cjs-chunk-98cdd37b.js","cjs-dropdowns-e7ee1fb5.js","cjs-chunk-e26655d2.js","cjs-chunk-f4c68e62.js","cjs-chunk-d6ceb400.js"]);
