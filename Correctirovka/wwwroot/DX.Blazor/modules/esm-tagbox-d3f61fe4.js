import"./esm-chunk-eaca7b99.js";import{SetInputAttribute as e,elementIsInDOM as t,EnsureElement as o,GetParentByClassName as n,SetPositionOfDropDown as r,AttachEventToElement as u,DetachEventFromElement as a}from"./esm-dom-utils-57c82d80.js";import{D as s,R as i}from"./esm-chunk-f7983851.js";import{T as c}from"./esm-chunk-e0d053f7.js";import{K as d}from"./esm-chunk-6d4715b2.js";import{OnOutsideClick as f,IsDropDownVisible as l}from"./esm-dropdowns-871dcdb9.js";import"./esm-chunk-95f069f9.js";import{a as m,H as p,G as v}from"./esm-chunk-94dee8b1.js";import{K as y,a as k}from"./esm-chunk-511b3c8e.js";var h=200,T=h/2;function g(e){!function(e){if(!t(e))return;var o=function(e){var t=e.querySelector("*[id$='_LB']");t||(t=e.parentNode.querySelector("*[id$='_LB']"));t||(t=e);if(t){var o=t.querySelector(m.ListBoxFocusedItem);if(o)return o.parentNode}return null}(e);if(o){var n=e,r=n.scrollTop>o.offsetTop,u=n.scrollTop+n.clientHeight<o.offsetTop+o.offsetHeight;r&&(n.scrollTop=o.offsetTop),u&&(n.scrollTop=o.offsetTop-(n.clientHeight-o.offsetHeight))}}(E(e))}function w(t,o,n){e(t,"value",o),C(t),n&&function(e){e&&e.select()}(t)}function C(e){e.previousSibling.innerText=""==e.value&&e.placeholder?e.placeholder:e.value}function I(e){e=o(e),document.activeElement===e&&D(e)}function b(e,t){var o=e.target;F(o,!0),function(e){if(e){var t=n(e,"form-control");t.dataset.bluredClass&&(t.className=t.dataset.bluredClass)}}(o),o.dataset.timerId=window.setTimeout(function(){if(delete o.dataset.timerId,document.activeElement!==o)try{x(t,o)}catch(e){}},h)}function F(e,t){e.dataset.timerId&&(clearTimeout(e.dataset.timerId),delete e.dataset.timerId),t||window.setTimeout(function(){F(e,!0)},T)}function D(e){if(e){var t=n(e,"form-control");t.dataset.focusedClass&&(t.className=t.dataset.focusedClass)}}function K(e,t){return t&&y(e),function(e){return j(e)}(e)&&(e.stopPropagation(),e.preventDefault()),!1}function L(e,t,o,n){var r=!1;if(n&&(r=r||k(e)),r=r||function(e){var t=e.altKey&&(e.keyCode==d.Down||e.keyCode==d.Up),o=j(e),n=e.keyCode==d.Esc||e.keyCode==d.Enter,r=function(e){var t=0==e.target.value.length;return e.keyCode==d.Backspace&&t}(e);return t||o||n||r}(e)){var u=e.target.value,a=""!=e.target.dataset.previousValue;if(o&&p(o)){var s=v(o,!1);t.invokeMethodAsync("OnTagBoxListBoxKeyUp",u,e.keyCode,e.altKey,e.ctrlKey,s.itemHeight,s.scrollTopForRequest,s.scrollHeightForRequest,a)}else t.invokeMethodAsync("OnTagBoxKeyUp",u,e.keyCode,e.altKey,e.ctrlKey,a)}}function j(e){return e.keyCode===d.Down||e.keyCode===d.Up||e.keyCode===d.PageUp||e.keyCode===d.PageDown||e.ctrlKey&&(e.keyCode===d.Home||e.keyCode===d.End)}function x(e,t,o){if(t){var n=(new Date).getTime();t.dataset.lastLostFocusTime&&n-t.dataset.lastLostFocusTime<h+100&&!o||(t.dataset.lastLostFocusTime=(new Date).getTime(),document.activeElement!=t&&(t.value=""),e.invokeMethodAsync("OnTagBoxLostFocus",t.value))}}function E(e){return(e=o(e)).querySelector("div.dxbs-dm.dropdown-menu")}function B(e,n,d,m,p){if(e=o(e)){s(e),m="true"===m.toLowerCase(),p="true"===p.toLowerCase(),n=o(n);var v=E(e);r(e,v);var y=v;p&&g(e);var k=function(e){return K(e,m)},h=function(e){return L(e,d,y,m)},T=function(e){return function(e,t){D(e.target)}(e)},w=function(e){return b(e,d)},I=function(e){return C(e.target)},j=function(e){return F(n)},B=function(o){return f(o,e,function(){t(e)||s(e);var o=document.activeElement===n,r=n.dataset.timerId>0,u=v&&l(v);F(n),(o||r||u)&&x(d,n,!0)})};return u(n,"keydown",k),u(n,"keyup",h),u(n,"focus",T),u(n,"blur",w),u(n,"input",I),u(e,"mousedown",j),u(document,c.touchMouseDownEventName,B),i(e,function(){a(n,"keydown",k),a(n,"keyup",h),a(n,"focus",T),a(n,"blur",w),a(n,"input",I),a(e,"mousedown",j),a(document,c.touchMouseDownEventName,B)}),C(n),Promise.resolve("ok")}}function H(e){if(e=o(e))return s(e),Promise.resolve("ok")}const q={Init:B,Dispose:H,PrepareInputIfFocused:I,ScrollToFocusedItem:g,FitInputWidth:C,ForceInputValue:w};export default q;export{H as Dispose,C as FitInputWidth,w as ForceInputValue,B as Init,I as PrepareInputIfFocused,g as ScrollToFocusedItem};
