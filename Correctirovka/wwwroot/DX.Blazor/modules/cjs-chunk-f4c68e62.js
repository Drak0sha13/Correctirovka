DxBlazorInternal.define("cjs-chunk-f4c68e62.js",function(e,t,o){var l=e("./cjs-chunk-9eab2df8.js"),n=e("./cjs-dom-utils-9e3f000c.js"),r=e("./cjs-chunk-f8581dee.js"),i=e("./cjs-chunk-ea895bfc.js");e("./cjs-chunk-98cdd37b.js");var c=e("./cjs-chunk-e26655d2.js"),a={GridSelectedRowCell:".dxbs-table td.table-active",ListBoxSelectedItem:".dropdown-item.active",ListBoxFocusedItem:".dropdown-item.focused"},u="data-dxdg-draggable",s={GroupPanelHead:"gph",ColumnHead:"ch"};function d(e){if(!e.hasAttribute(u))return null;var t=e.getAttribute(u).split("|"),o=!(t.length>2)||"1"===t[2],l=t.length>1?s[t[1]]:s.ColumnHead,n=l==s.ColumnHead?parseInt(t[0]):-1,r=l==s.GroupPanelHead?parseInt(t[0]):-1,i=e.previousElementSibling;return{columnVisibleIndex:n,groupVisibleIndex:r,columnHeadType:l,canBeGrouped:o,needInsertBeforeToo:!i||!d(i)}}function p(e){return"["+u+"-id="+e+"]"}function m(e,t,o){var l,n,r;l=e,n=f(t,"clientX")-o.left,r=f(t,"clientY")-o.top,void(l.style.transform=["translate(",Math.round(n),"px, ",Math.round(r),"px)"].join(""))}function f(e,t){return void 0!==e[t]?e[t]:void 0!==e.touches?e.touches[0][t]:0}function h(e,t,o){var r=f(e,"clientX"),c=f(e,"clientY"),a=e.target,u=!1,h=function(e){var l=Math.abs(r-f(e,"clientX"))>10,h=Math.abs(c-f(e,"clientY"))>10;return(l||h)&&(u=!0,S(),function(e,t,o,l){var r=p(o),c=n.findParentBySelector(t,r);if(!c)return;var a=d(c),u=n.getDocumentScrollLeft(),h=n.getDocumentScrollTop(),S={left:0,top:0},H=function(e,t){for(var o=[],l=p(t),n=document.querySelectorAll(l),r=!1,i=!1,c=0;c<n.length;c++){var a=n[c],u=a.getBoundingClientRect(),m=d(a),f=m.columnVisibleIndex,h=m.groupVisibleIndex,v=m.needInsertBeforeToo,T=m.columnHeadType;T==s.GroupPanelHead?r=!0:T==s.ColumnHead&&(i=!0),v&&o.push(new g(a,u.left,u.top,u.bottom,f,h,T,!0,!1)),o.push(new g(a,u.right,u.top,u.bottom,f,h,T,!1,!1))}if(r||i){if(!r){var S=document.querySelector("[data-dxdg-drag-group-panel="+t+"]");if(S){var u=S.getBoundingClientRect();o.push(new g(S,u.left,u.top,u.bottom,-1,0,s.GroupPanelHead,!1,!0,!0))}}if(!i){var H=document.querySelector("[data-dxdg-drag-head-row="+t+"]");if(H){var u=H.getBoundingClientRect();o.push(new g(H,u.right,u.top,u.bottom,0,-1,s.ColumnHead,!1,!0,!0))}}}return o}(0,o),y=function(e,t){var o=e.cloneNode(!0),l=e.getBoundingClientRect(),n={left:f(t,"clientX")-l.left,top:f(t,"clientY")-l.top};if("DIV"!=o.tagName){var r=document.createElement("DIV"),i=window.getComputedStyle(e);r.innerHTML=o.innerHTML,r.className="card "+e.className,r.style.width=e.offsetWidth+"px",r.style.height=e.offsetHeight+"px",r.style.paddingTop=i.paddingTop,r.style.paddingBottom=i.paddingBottom,r.style.paddingLeft=i.paddingLeft,r.style.paddingRight=i.paddingRight,o=r}else o.style.width=e.offsetWidth+"px",o.style.height=e.offsetHeight+"px";o.className=o.className+" dx-dragging-state",document.body.appendChild(o);var c=o.getBoundingClientRect();return{dragElement:o,offsetFromMouse:{left:c.left+n.left,top:c.top+n.top}}}(c,e),E=y.dragElement,b=y.offsetFromMouse;m(E,e,b);var x=!0,I=null,R=function(e){x&&(E.style.visibility="visible",x=!1);var t={left:b.left+S.left,top:b.top+S.top};return m(E,e,t),I=function(e,t,o,l,r){!function(e){for(var t=p(e),o=document.querySelectorAll("div."+T+t),l=0;l<o.length;l++){var n=o[l];n.parentNode.removeChild(n)}}(t);for(var i=null,c=[],a=f(l,"clientX"),u=f(l,"clientY"),d=0;d<e.length;d++){var m=e[d];if(!v(o,m)&&(m.columnHeadType!=s.GroupPanelHead||o.canBeGrouped)){var h=m.top+r.top<=u&&u<=m.bottom+r.top;if(h){if(m.wholeRowIsRarget){i=m;break}c.push({distance:Math.abs(Math.abs(m.x+r.left)-Math.abs(a)),target:m})}}}if(null==i){var g=1e6;for(var d in c)g>c[d].distance&&(g=c[d].distance,i=c[d].target)}null!=i&&!function(e,t){var o=document.createElement("DIV");o.className=T,o.dataset.dxdgDraggableId=t,o.style.top=e.top+(e.docScrollTop-n.getDocumentScrollTop())+n.getDocumentScrollTop()-1-1+"px",o.style.height=e.bottom-e.top+2+"px",o.style.left=e.x+(e.docScrollLeft-n.getDocumentScrollLeft())+n.getDocumentScrollLeft()+"px",o.innerHTML=["<span class='oi oi-arrow-bottom' aria-hidden='true'></span>","<div style='height:",o.style.height,"'></div>","<span class='oi oi-arrow-top' aria-hidden='true'></span>"].join(""),document.body.appendChild(o),e.mark=o}(i,t);return i}(H,o,a,e,S),e.preventDefault(),!1},w=function(){if(I){var e=a.columnHeadType==s.GroupPanelHead?a.groupVisibleIndex:a.columnVisibleIndex,t=I.columnHeadType==s.GroupPanelHead?I.groupVisibleIndex:I.columnVisibleIndex;l.invokeMethodAsync("OnGridColumnHeadDragNDrop",e,a.columnHeadType,t,I.columnHeadType,I.insertBefore),I.mark.parentNode.removeChild(I.mark)}n.DetachEventFromElement(document,i.TouchUIHelper.touchMouseMoveEventName,R),n.DetachEventFromElement(document,i.TouchUIHelper.touchMouseUpEventName,w),n.DetachEventFromElement(window,"scroll",D),E.parentNode.removeChild(E)},D=function(){S={left:u-n.getDocumentScrollLeft(),top:h-n.getDocumentScrollTop()}};n.AttachEventToElement(document,i.TouchUIHelper.touchMouseMoveEventName,R),n.AttachEventToElement(document,i.TouchUIHelper.touchMouseUpEventName,w),n.AttachEventToElement(window,"scroll",D)}(e,a,t,o)),e.preventDefault(),!1},S=function(){n.DetachEventFromElement(document,i.TouchUIHelper.touchMouseMoveEventName,h),n.DetachEventFromElement(document,i.TouchUIHelper.touchMouseUpEventName,S),!u&&a&&l.Browser.WebKitTouchUI&&a.click()};return n.AttachEventToElement(document,i.TouchUIHelper.touchMouseMoveEventName,h),n.AttachEventToElement(document,i.TouchUIHelper.touchMouseUpEventName,S),e.preventDefault(),!1}function g(e,t,o,l,r,i,c,a,u){this.element=e,this.x=t,this.top=o,this.bottom=l,this.columnVisibleIndex=r,this.groupVisibleIndex=i,this.columnHeadType=c,this.insertBefore=a,this.wholeRowIsRarget=u,this.docScrollTop=n.getDocumentScrollTop(),this.docScrollLeft=n.getDocumentScrollLeft()}function v(e,t){function o(e,t){return t.groupVisibleIndex==e.groupVisibleIndex||t.groupVisibleIndex==e.groupVisibleIndex-1&&!t.insertBefore}function l(e,t){return t.columnVisibleIndex==e.columnVisibleIndex||t.columnVisibleIndex==e.columnVisibleIndex-1&&!t.insertBefore}return!(t.columnHeadType!=e.columnHeadType||e.columnHeadType!=s.GroupPanelHead||!o(e,t))||(!(t.columnHeadType!=e.columnHeadType||e.columnHeadType!=s.ColumnHead||!l(e,t))||(!(e.columnHeadType!=s.GroupPanelHead||t.columnHeadType!=s.ColumnHead||-1==e.columnVisibleIndex||!l(e,t))||!(e.columnHeadType!=s.ColumnHead||t.columnHeadType!=s.GroupPanelHead||-1==e.groupVisibleIndex||!o(e,t))))}s[1]=s.ColumnHead,s[0]=s.GroupPanelHead;var T="dxgv-target-marks";var S=200;function H(e){if(n.elementIsInDOM(e)){if(!(t=function(e){var t=e.querySelector("*[id$='_LB']");t||(t=e.parentNode.querySelector("*[id$='_LB']"));t||(t=e);if(t){var o=t.querySelector(a.ListBoxSelectedItem);if(o)return o.parentNode}return null}(e)))var t=function(e){var t=null;n.QuerySelectorFromRoot(e,function(o){t=e.querySelector("*"+o+" > *[id$='_LB']")}),t||n.QuerySelectorFromRoot(e.parentNode,function(o){t=e.parentNode.querySelector("*"+o+" > *[id$='_LB']")});var o=t?t.querySelector(a.GridSelectedRowCell):null;return o?o.parentNode:null}(e);if(t){var o=e,l=o.scrollTop+o.clientHeight<t.offsetTop+t.offsetHeight;o.scrollTop>t.offsetTop&&(o.scrollTop=t.offsetTop),l&&(o.scrollTop=t.offsetTop-(o.clientHeight-t.offsetHeight))}}}function y(e,t,o,l,n,r){var i=e.currentTarget;E(e,t,o,i,l),i.dataset.InScrollRequest||(b(i),i.dataset.OnScrollTimerId=window.setTimeout(function(){!function(e,t,o,l,n,r,i){b(l);var c=!0;l.dataset.prevScrollTop?c=l.dataset.prevScrollTop!=l.scrollTop.toString():l.dataset.prevScrollTop=l.scrollTop;c&&o.isVirtualScrolling&&!function(e,t,o,l,n){var r=x(t),i=w(t,n),c=i.itemHeight,a=i.scrollTop,u=i.scrollBottom,s=i.scrollTopForRequest,d=i.scrollHeightForRequest,p=l.clientHeight>0&&u>o.offsetHeight+r.offsetHeight;(o.clientHeight>0&&a<o.offsetHeight||p)&&(t.dataset.InScrollRequest=!0,function(e,t,o,l,n){if(e.dxScrollCache){if(e.dxScrollCache.itemHeight===o&&e.dxScrollCache.scrollTopForRequest===l&&e.dxScrollCache.scrollHeightForRequest===n)return}else e.dxScrollCache={itemHeight:o,scrollTopForRequest:l,scrollHeightForRequest:n};t.DxRestoreScrollTop=t.scrollTop,e.invokeMethodAsync("OnGridVirtualScroll",o,l,n).then(function(t){!function(e,t){e.dotNetComponentReference=t,B(e)}(t,e)}).catch(D)}(e,t,c,s,d))}(t,l,r,i,!1);E(e,t,o,l,n)}(e,t,o,i,l,n,r)},S),window.setTimeout(function(){E(e,t,o,i,l)},0))}function E(e,t,o,l,n,r,i){o.isHorizontalScrolling&&(n.scrollLeft=l.scrollLeft)}function b(e){e.dataset.OnScrollTimerId&&(clearTimeout(e.dataset.OnScrollTimerId),delete e.dataset.OnScrollTimerId)}function x(e){var t=e.querySelector("table.dxbs-table"),o=e.parentNode.querySelector("div.dxbs-listbox > ul");return t||o}function I(e,t,o,l,n){var r=x(t),i=function(e,t){var o=R(e);return{itemHeight:o,spacerTop:t.virtualScrollingOptions.itemsAbove*o,spacerBelow:t.virtualScrollingOptions.itemsBelow*o}}(r,n);o.style.height=i.spacerTop+"px",l.style.height=i.spacerBelow+"px",function(e,t,o,l){if(e.clientHeight>t.offsetHeight)return;e.scrollTop<o.clientHeight&&(e.scrollTop=o.clientHeight+1);e.scrollTop+e.clientHeight>o.clientHeight+t.offsetHeight&&(e.scrollTop=o.clientHeight+t.offsetHeight-e.clientHeight-1)}(t,r,o)}function R(e){for(var t=function(e){var t=[];return e.dataset.tempUniqueId="tempUniqueId","TABLE"===e.tagName?t=e.parentNode.querySelectorAll("TABLE[data-temp-unique-id] > TBODY > TR"):"UL"===e.tagName&&(t=e.parentNode.querySelectorAll("ul[data-temp-unique-id] > li")),delete e.dataset.tempUniqueId,t}(e),o={},l=0;l<t.length;l++){var n=t[l];o[n.offsetHeight]=o[n.offsetHeight]?o[n.offsetHeight]+1:1}var r=0,i=0;for(var c in o)o[c]>i&&(i=o[c],r=c);return Number.parseInt(r)}function w(e,t){var o=300,l=300;t&&(o=0,l=0);var n=x(e),r=e.scrollTop-o;r<0&&(r=0);var i=e.scrollTop+e.clientHeight+l,c=r-o;c<0&&(c=0);var a=i-c+l;return{itemHeight:R(n),scrollTop:r,scrollBottom:i,scrollTopForRequest:c,scrollHeightForRequest:a}}function D(e){e&&e.mainElement&&N(e.mainElement)}function q(e,t){return(t.isVerticalScrolling||t.isVirtualScrolling)&&(e.clientHeight<e.scrollHeight||"scroll"==e.style.overflowY)}function V(e){for(var t=e.querySelectorAll(".btn.btn-toggle"),o=0,l=0;l<t.length;l++){var r=t[l],i=r.offsetWidth+n.GetLeftRightBordersAndPaddingsSummaryValue(r.parentNode);if(i>0){o=i;break}}var c,a=n.GetCurrentStyleSheet(),u=e.getAttribute("data-dxdg-id"),s=null;return a&&(a.insertRule("[data-dxdg-id='"+u+"'] > col.dxbs-grid-cols-togglebtn { width:"+o+"px !important; }",a.cssRules.length),s=a.cssRules[a.cssRules.length-1]),c=s,function(){if(c.ownerStyleSheet){var e=c.parentStyleSheet,t=Array.prototype.indexOf.call(e.cssRules,c);t>-1&&e.deleteRule(t)}}}function B(e){var t=n.EnsureElement(e.mainElement);if(t){var o=e.dotNetComponentReference,l=e.scrollToSelectedItemRequested,a=e.elementsStorage,u=n.EnsureElement(a.scrollElement),s=n.EnsureElement(a.scrollHeaderElement),d=n.EnsureElement(a.virtualScrollSpacerTopElement),p=n.EnsureElement(a.virtualScrollSpacerBottomElement);t=n.EnsureElement(t),r.DisposeEvents(t);var m=null,f=null,g=null,v=null;u=n.EnsureElement(u);var T=null;u&&(s=n.EnsureElement(s),u.dataset.InScrollRequest=!0,e.isVirtualScrolling&&(d=n.EnsureElement(d),p=n.EnsureElement(p)),(e.isVirtualScrolling||e.isVerticalScrolling)&&function(e,t,o){if((o.isVerticalScrolling||o.isVirtualScrolling)&&t){var l=[t];if(q(e,o)){var n=c.GetVerticalScrollBarWidth();if(17!==n||o.isHorizontalScrolling)for(var r=o.isHorizontalScrolling?"paddingRight":"marginRight",i=o.isHorizontalScrolling?"marginRight":"paddingRight",a=0,u=l.length;a<u;a++)l[a].style[r]="0",l[a].style[i]=n+"px";else e.style.paddingRight="",e.style.marginRight="",t.style.paddingRight="",t.style.marginRight=""}else e.style.paddingRight="0",e.style.marginRight="0",t.style.paddingRight="0",t.style.marginRight="0"}}(u,s,e),e.isVirtualScrolling&&(I(0,u,d,p,e),l?H(u):u.DxRestoreScrollTop&&(u.scrollTop=u.DxRestoreScrollTop,delete u.DxRestoreScrollTop)),T=V(t),delete u.dataset.InScrollRequest,n.AttachEventToElement(u,"scroll",m=function(t){return y(t,o,e,s,d,p)}),function(e){return e.isHorizontalScrolling||e.isVerticalScrolling}(e)&&((f=function(){!function(e,t,o,l,n,r){if(t){t.dataset.InScrollRequest=!0;var i=t.style.overflowX;t.style.overflowX="hidden",t.style.width="0"}if(o){var a=o.style.overflowX;o.style.overflowX="hidden",o.style.width="0"}var u=e.clientWidth;if(t&&(u&&(t.style.width=u+"px"),t.style.overflowX=i),o){var s=q(t,r)?c.GetVerticalScrollBarWidth():0;u&&(o.style.width=u-s+"px"),o.style.overflowX=a}t&&delete t.dataset.InScrollRequest}(t,u,s,0,0,e)})(),n.AttachEventToElement(window,"resize",f)));var S=null,E=null;if(e.isColumnDragEnabled){var x=t.dataset.dxdgId;x&&((S=t.querySelector("[data-dxdg-drag-head-row='"+x+"']"))&&n.AttachEventToElement(S,i.TouchUIHelper.touchMouseDownEventName,g=function(e){return h(e,x,o)}),(E=t.querySelector("[data-dxdg-gp='"+x+"']"))&&n.AttachEventToElement(E,i.TouchUIHelper.touchMouseDownEventName,v=function(e){return h(e,x,o)}))}return r.RegisterDisposableEvents(t,function(){T&&T(),m&&n.DetachEventFromElement(u,"scroll",m),f&&n.DetachEventFromElement(window,"resize",f),u&&b(u),g&&S&&n.DetachEventFromElement(S,i.TouchUIHelper.touchMouseDownEventName,g),v&&E&&n.DetachEventFromElement(E,i.TouchUIHelper.touchMouseDownEventName,v)}),Promise.resolve("ok")}}function N(e){return(e=n.EnsureElement(e))&&r.DisposeEvents(e),Promise.resolve("ok")}var C={Init:B,Dispose:N};o.Dispose=N,o.GetParametersForVirtualScrollingRequest=w,o.HasParametersForVirtualScrollingRequest=function(e){return null!==x(e)},o.Init=B,o.ScrollToSelectedItem=H,o.Selectors=a,o.grid=C},["cjs-chunk-9eab2df8.js","cjs-dom-utils-9e3f000c.js","cjs-chunk-f8581dee.js","cjs-chunk-ea895bfc.js","cjs-chunk-98cdd37b.js","cjs-chunk-e26655d2.js"]);
