import"./esm-chunk-eaca7b99.js";import{EnsureElement as e,AttachEventToElement as n,GetParentByClassName as t,SetPositionOfDropDown as o,changeDom as r,elementIsInDOM as c,DetachEventFromElement as u}from"./esm-dom-utils-57c82d80.js";import{D as s,R as i}from"./esm-chunk-f7983851.js";import{T as a}from"./esm-chunk-e0d053f7.js";import{K as d}from"./esm-chunk-6d4715b2.js";const l=document.body,f={},m=[],v={subtree:!0,childList:!0},E=new MutationObserver(function(e,n){for(let n=0;n<e.length;n++)e[n].removedNodes.forEach(function(e){m.filter(n=>e===n.element).map(e=>e.callback).forEach(e=>e())})});function p(e){return f[e]||(f[e]=new Promise((n,t)=>{0===m.length&&E.observe(l,v),function(e,n){var t={element:e,callback:function(){m.splice(m.indexOf(t),1),delete f[e],0===m.length&&E.disconnect(),n()}};m.push(t)}(e,n)}))}const h={Popup:0,Modal:1};function D(e,n,t){for(var o=e.target;o;){if(o===n)return!1;o=o.parentElement}t&&t()}function g(e){return"none"!==e.style.display}const b="a[href], input:not([disabled]), button:not([disabled]), [tabindex]:not([tabindex='-1'])";const N={Init:function(t,o,r,d){if(t=e(t),o=e(o),r=e(r),t){if(s(t),r){var l=function(e){return D(e,t,function(){c(t)||s(t);var e=document.activeElement===o,n=r&&g(r);(e||n)&&d.invokeMethodAsync("OnDropDownLostFocus",o.value)})};n(document,a.touchMouseDownEventName,l),i(t,function(){u(document,a.touchMouseDownEventName,l)})}return Promise.resolve("ok")}},Dispose:function(n){return(n=e(n))&&s(n),Promise.resolve("ok")},ShowAdaptiveDropdown:function(n,c,u,s,i){n=e(n);var l=t(n,u),f=(l.querySelector("."+s),document.documentElement);c===h.Popup&&o(l,n);var m=!1;function v(e){(!n.contains(e.srcElement)||c===h.Modal&&n===e.srcElement)&&D()}function E(e){f.removeEventListener("focusin",E),null===e.relatedTarget&&e.target&&n.contains(e.target)&&e.target.focus()}function D(){m||(m=!0,g(),i.invokeMethodAsync("CloseDialog"))}function g(){f.removeEventListener(a.touchMouseDownEventName,v)}function N(){var e=n.querySelector(b);e&&e.focus()}return f.addEventListener(a.touchMouseDownEventName,v),n.addEventListener("keydown",function(e){e.keyCode===d.Esc&&D()}),n.addEventListener("focusout",function(e){var t,o,r,c;m||(null===e.relatedTarget||n.contains(e.relatedTarget)?null===e.relatedTarget&&f.addEventListener("focusin",E):void((t=n.compareDocumentPosition(e.relatedTarget))&Node.DOCUMENT_POSITION_PRECEDING?(r=n,c=r.querySelectorAll(b),o=c[c.length-1],void(o&&o.focus())):t&Node.DOCUMENT_POSITION_FOLLOWING&&N()))}),c===h.Modal&&n.addEventListener("touchmove",e=>{e.srcElement===n&&e.preventDefault()}),p(n).then(()=>{g()}),r(N),Promise.resolve()}};export default N;export{g as IsDropDownVisible,D as OnOutsideClick};
