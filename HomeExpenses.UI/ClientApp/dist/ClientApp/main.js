(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"body__fullscreen\">\r\n  <router-outlet></router-outlet>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/app.component.scss":
/*!************************************!*\
  !*** ./src/app/app.component.scss ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".body__fullscreen {\n  height: 100vh;\n  width: 100vw; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXGFwcFxcYXBwLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsY0FBYTtFQUNiLGFBQVksRUFDYiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5ib2R5X19mdWxsc2NyZWVuIHtcclxuICBoZWlnaHQ6IDEwMHZoO1xyXG4gIHdpZHRoOiAxMDB2dztcclxufVxyXG4iXX0= */"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var AppComponent = /** @class */ (function () {
    function AppComponent() {
    }
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.scss */ "./src/app/app.component.scss")]
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _modules_main_main_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./modules/main/main.module */ "./src/app/modules/main/main.module.ts");
/* harmony import */ var _app_routing__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./app.routing */ "./src/app/app.routing.ts");
/* harmony import */ var _shared_modules_material_material_module__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./shared/modules/material/material.module */ "./src/app/shared/modules/material/material.module.ts");
/* harmony import */ var _modules_recipients_recipients_module__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./modules/recipients/recipients.module */ "./src/app/modules/recipients/recipients.module.ts");











var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_4__["BrowserAnimationsModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
                _modules_main_main_module__WEBPACK_IMPORTED_MODULE_7__["MainModule"],
                _modules_recipients_recipients_module__WEBPACK_IMPORTED_MODULE_10__["RecipientsModule"],
                _shared_modules_material_material_module__WEBPACK_IMPORTED_MODULE_9__["MaterialModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_5__["RouterModule"],
                _app_routing__WEBPACK_IMPORTED_MODULE_8__["AppRoutesModule"]
            ],
            exports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"]
            ],
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"]
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/app.routing.ts":
/*!********************************!*\
  !*** ./src/app/app.routing.ts ***!
  \********************************/
/*! exports provided: AppRoutesModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutesModule", function() { return AppRoutesModule; });
/* harmony import */ var _modules_main_main_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./modules/main/main.component */ "./src/app/modules/main/main.component.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _modules_recipients_recipients_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./modules/recipients/recipients.component */ "./src/app/modules/recipients/recipients.component.ts");



var appRoutes = [
    {
        path: '',
        component: _modules_main_main_component__WEBPACK_IMPORTED_MODULE_0__["MainComponent"],
        children: [
            {
                path: 'recipients',
                component: _modules_recipients_recipients_component__WEBPACK_IMPORTED_MODULE_2__["RecipientsComponent"]
            }
        ]
    }
];
var AppRoutesModule = _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forRoot(appRoutes);


/***/ }),

/***/ "./src/app/modules/main/main.component.html":
/*!**************************************************!*\
  !*** ./src/app/modules/main/main.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"app\">\n  <app-toolbar></app-toolbar>\n\n  <mat-sidenav-container>\n    <mat-sidenav class=\"app_menu\" mode=\"side\" #sidenav [opened]=\"true\">\n      <app-side-menu></app-side-menu>\n    </mat-sidenav>\n    <mat-sidenav-content class=\"app__main\">\n      sdfsdfdsf\n      <router-outlet></router-outlet>\n    </mat-sidenav-content>\n  </mat-sidenav-container>\n</div>\n"

/***/ }),

/***/ "./src/app/modules/main/main.component.scss":
/*!**************************************************!*\
  !*** ./src/app/modules/main/main.component.scss ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/* SIZES DEFINITIONS\r\n-----------------------------------------------------*/\n/* SIDE MENU\r\n------------------------*/\n/* FONTS\r\n------------------------*/\n/* PADDING\r\n------------------------*/\n/* Z_INDEX\r\n-----------------------------*/\n/* PIXELATE FUNCTION\r\n-------------------------------------------------------------------------------*/\n/*@function strip-unit($num) {\r\n  @return $num / ($num * 0 + 1);\r\n}*/\n/* STRIP-UNIT FUNCTION\r\n-------------------------------------------------------------------------------*/\n/* BOX-SHADOW MIXIN\r\n-------------------------------------------------------------------------------*/\n/* CLASS CREATION MIXIN\r\n-------------------------------------------------------------------------------*/\n/* FONT MIXIN\r\n-------------------------------------------------------------------------------*/\n/* CHOOSE FONT\r\n    Function takes fonts, that are in variable and than\r\n    it gives name of proper font\r\n-------------------------------------------------------------------------------*/\n/* MARGIN MIXIN\r\n-------------------------------------------------------------------------------*/\n/* PADDING MIXIN\r\n-------------------------------------------------------------------------------*/\n/* POSITION MIXIN\r\n-------------------------------------------------------------------------------*/\n/* PSEUDO ELEMENT MIXIN\r\n-------------------------------------------------------------------------------*/\n/* BORDER RADIUS MIXIN\r\n-------------------------------------------------------------------------------*/\n/* ELEMENT SIZE MIXIN\r\n-------------------------------------------------------------------------------*/\n/* TRANSITION MIXIN\r\n-------------------------------------------------------------------------------*/\n/* WORD WRAP MIXIN\r\n-------------------------------------------------------------------------------*/\n/* Z-INDEX MIXIN\r\n-------------------------------------------------------------------------------*/\n/* OVERLAY MIXIN\r\n-------------------------------------------------------------------------------*/\n/* TRUNCATE MIXIN\r\n-------------------------------------------------------------------------------*/\n/* INPUT PLACEHOLDER MIXIN\r\n-------------------------------------------------------------------------------*/\n/* RESPONSIVE RATIO MIXIN\r\n-------------------------------------------------------------------------------*/\n/* HARDWARE ACCELERATE MIXIN\r\n-------------------------------------------------------------------------------*/\n/* UNORDERED LIST WITH NO BULLETS\r\n-------------------------------------------------------------------------------*/\n/* CENTRALIZE CONTENT INSIDE DIV\r\n-------------------------------------------------------------------------------*/\n.app {\n  display: flex;\n  min-height: 100vh; }\n.app__main {\n    -moz-flex: 1;\n    flex: 1;\n    flex: auto;\n    width: calc(100vw - 19.375rem);\n    padding: 1.25rem 1.5625rem 1.875rem;\n    margin: 0 0 0 16.25rem; }\n.app__menu {\n    position: fixed;\n    width: 16.25rem;\n    height: 100vh; }\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFx2YXJpYWJsZXNcXF9zaXplcy5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXHZhcmlhYmxlc1xcX3otaW5kZXguc2NzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFxmdW5jdGlvbnNcXF9waXhlbGF0ZS5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXGZ1bmN0aW9uc1xcX3JlbS1jYWxjLnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcZnVuY3Rpb25zXFxfc3RyaXAtdW5pdC5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXG1peGluc1xcX2JveC1zaGFkb3cuc2NzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFxtaXhpbnNcXF9mb250LnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcbWl4aW5zXFxfbWFyZ2luLnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcbWl4aW5zXFxfcGFkZGluZy5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXG1peGluc1xcX3Bvc2l0aW9uLnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcbWl4aW5zXFxfcHNldWRvLnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcbWl4aW5zXFxfcmFkaXVzLnNjc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9DOlxcVXNlcnNcXHRkcnp5XFxzb3VyY2VcXHJlcG9zXFxIb21lRXhwZW5zZXNcXEhvbWVFeHBlbnNlcy5VSVxcQ2xpZW50QXBwL3NyY1xcc2Nzc1xcbWl4aW5zXFxfc2l6ZS5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXG1peGluc1xcX3RyYW5zaXRpb24uc2NzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFxtaXhpbnNcXF93b3Jkd3JhcC5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXHNjc3NcXG1peGluc1xcX3otaW5kZXguc2NzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFxtaXhpbnNcXF9vdGhlci5zY3NzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vQzpcXFVzZXJzXFx0ZHJ6eVxcc291cmNlXFxyZXBvc1xcSG9tZUV4cGVuc2VzXFxIb21lRXhwZW5zZXMuVUlcXENsaWVudEFwcC9zcmNcXGFwcFxcbW9kdWxlc1xcbWFpblxcbWFpbi5jb21wb25lbnQuc2NzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxzY3NzXFxtaXhpbnNcXF9mbGV4LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7dURBQ3VEO0FBRXZEOzBCQUMwQjtBQUsxQjswQkFDMEI7QUFTMUI7MEJBQzBCO0FDcEIxQjsrQkFDK0I7QUNEL0I7aUZBQ2lGO0FDY2pGOztHQUVHO0FDakJIO2lGQUNpRjtBQ0RqRjtpRkFDaUY7QUF5QmpGO2lGQUNpRjtBQzNCakY7aUZBQ2lGO0FBZ0JqRjs7O2lGQUdpRjtBQ3BCakY7aUZBQ2lGO0FDRGpGO2lGQUNpRjtBQ0RqRjtpRkFDaUY7QUNEakY7aUZBQ2lGO0FDRGpGO2lGQUNpRjtBQ0RqRjtpRkFDaUY7QUNEakY7aUZBQ2lGO0FDRGpGO2lGQUNpRjtBQ0RqRjtpRkFDaUY7QUNEakY7aUZBQ2lGO0FBV2pGO2lGQUNpRjtBQXVCakY7aUZBQ2lGO0FBV2pGO2lGQUNpRjtBQWdCakY7aUZBQ2lGO0FBVWpGO2lGQUNpRjtBQVNqRjtpRkFDaUY7QUNyRmpGO0VBQ0UsY0FBYTtFQUNiLGtCQUFpQixFQWdCbEI7QUFkQztJQ3dRRCxhQWRpQjtJQWdCakIsUUFoQmlCO0lEdFBkLFdBQVU7SUFDViwrQkFBd0U7SVRRcEUsb0NMcUVpRDtJSTlEakQsdUJKOERpRCxFYzFFdEQ7QUFFRDtJUlpFLGdCUWF1QjtJTFB2QixnQlQ4RXFEO0lTN0VyRCxjS09rRCxFQUNuRCIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9tYWluLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLyogU0laRVMgREVGSU5JVElPTlNcclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuLyogU0lERSBNRU5VXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcbiRzaWRlbWVudV9fc2l6ZS0tZnVsbDogMjYwcHg7XHJcbiRzaWRlbWVudV9fc2l6ZS0tbW9iaWxlOiA3NXB4O1xyXG5cclxuXHJcbi8qIEZPTlRTXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcbiRmb250LXNpemUgOiAoXHJcbiAgICBoaW50OiAgIDEycHgsXHJcbiAgICBzbWFsbDogIDEycHgsXHJcbiAgICBtZWRpdW06IDE0cHgsXHJcbiAgICBjb21tb246IDE2cHgsXHJcbiAgICBoZWFkZXI6IDI0cHhcclxuKTtcclxuXHJcbi8qIFBBRERJTkdcclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuJGRpYWxvZ19fcGFkZGluZzogMzBweDsiLCIvKiBaX0lOREVYXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbiR6LWluZGV4OiAoXHJcbiAgICBtb2RhbCAgICAgICAgICAgOiAgIDcwXHJcbik7XHJcbiIsIu+7vy8qIFBJWEVMQVRFIEZVTkNUSU9OXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuLy8gSXQgdHVybnMgYW55IHZhbHVlJ3MgdW5pdCBpbiAncHgnLlxyXG4vLyBEb2Vzbid0IGNoYW5nZSB0aGUgdmFsdWUgaXRzZWxmLlxyXG5cclxuQGZ1bmN0aW9uIHBpeGVsYXRlKCR2YWx1ZSkge1xyXG4gICAgQHJldHVybiBzdHJpcC11bml0KCR2YWx1ZSkgKiAxcHg7XHJcbn0iLCLvu78vLyBGb3VuZGF0aW9uIGZvciBTaXRlcyBieSBaVVJCXHJcbi8vIGZvdW5kYXRpb24uenVyYi5jb21cclxuLy8gTGljZW5zZWQgdW5kZXIgTUlUIE9wZW4gU291cmNlXHJcblxyXG4vLy8vXHJcbi8vLyBAZ3JvdXAgZnVuY3Rpb25zXHJcbi8vLy9cclxuXHJcbiRnbG9iYWwtZm9udC1zaXplOiAxMDAlICFkZWZhdWx0O1xyXG5cclxuLy8vIFJlbW92ZXMgdGhlIHVuaXQgKGUuZy4gcHgsIGVtLCByZW0pIGZyb20gYSB2YWx1ZSwgcmV0dXJuaW5nIHRoZSBudW1iZXIgb25seS5cclxuLy8vXHJcbi8vLyBAcGFyYW0ge051bWJlcn0gJG51bSAtIE51bWJlciB0byBzdHJpcCB1bml0IGZyb20uXHJcbi8vL1xyXG4vLy8gQHJldHVybnMge051bWJlcn0gVGhlIHNhbWUgbnVtYmVyLCBzYW5zIHVuaXQuXHJcbi8qQGZ1bmN0aW9uIHN0cmlwLXVuaXQoJG51bSkge1xyXG4gIEByZXR1cm4gJG51bSAvICgkbnVtICogMCArIDEpO1xyXG59Ki9cclxuXHJcbi8vLyBDb252ZXJ0cyBvbmUgb3IgbW9yZSBwaXhlbCB2YWx1ZXMgaW50byBtYXRjaGluZyByZW0gdmFsdWVzLlxyXG4vLy9cclxuLy8vIEBwYXJhbSB7TnVtYmVyfExpc3R9ICR2YWx1ZXMgLSBPbmUgb3IgbW9yZSB2YWx1ZXMgdG8gY29udmVydC4gQmUgc3VyZSB0byBzZXBhcmF0ZSB0aGVtIHdpdGggc3BhY2VzIGFuZCBub3QgY29tbWFzLiBJZiB5b3UgbmVlZCB0byBjb252ZXJ0IGEgY29tbWEtc2VwYXJhdGVkIGxpc3QsIHdyYXAgdGhlIGxpc3QgaW4gcGFyZW50aGVzZXMuXHJcbi8vLyBAcGFyYW0ge051bWJlcn0gJGJhc2UgW251bGxdIC0gVGhlIGJhc2UgdmFsdWUgdG8gdXNlIHdoZW4gY2FsY3VsYXRpbmcgdGhlIGByZW1gLiBJZiB5b3UncmUgdXNpbmcgRm91bmRhdGlvbiBvdXQgb2YgdGhlIGJveCwgdGhpcyBpcyAxNnB4LiBJZiB0aGlzIHBhcmFtZXRlciBpcyBgbnVsbGAsIHRoZSBmdW5jdGlvbiB3aWxsIHJlZmVyZW5jZSB0aGUgYCRiYXNlLWZvbnQtc2l6ZWAgdmFyaWFibGUgYXMgdGhlIGJhc2UuXHJcbi8vL1xyXG4vLy8gQHJldHVybnMge0xpc3R9IEEgbGlzdCBvZiBjb252ZXJ0ZWQgdmFsdWVzLlxyXG5AZnVuY3Rpb24gcmVtLWNhbGMoJHZhbHVlcywgJGJhc2U6IG51bGwpIHtcclxuICAkcmVtLXZhbHVlczogKCk7XHJcbiAgJGNvdW50OiBsZW5ndGgoJHZhbHVlcyk7XHJcblxyXG4gIC8vIElmIG5vIGJhc2UgaXMgZGVmaW5lZCwgZGVmZXIgdG8gdGhlIGdsb2JhbCBmb250IHNpemVcclxuICBAaWYgJGJhc2UgPT0gbnVsbCB7XHJcbiAgICAkYmFzZTogJGdsb2JhbC1mb250LXNpemU7XHJcbiAgfVxyXG5cclxuICAvLyBJZiB0aGUgYmFzZSBmb250IHNpemUgaXMgYSAlLCB0aGVuIG11bHRpcGx5IGl0IGJ5IDE2cHhcclxuICAvLyBUaGlzIGlzIGJlY2F1c2UgMTAwJSBmb250IHNpemUgPSAxNnB4IGluIG1vc3QgYWxsIGJyb3dzZXJzXHJcbiAgQGlmIHVuaXQoJGJhc2UpID09ICclJyB7XHJcbiAgICAkYmFzZTogKCRiYXNlIC8gMTAwJSkgKiAxNnB4O1xyXG4gIH1cclxuXHJcbiAgLy8gVXNpbmcgcmVtIGFzIGJhc2UgYWxsb3dzIGNvcnJlY3Qgc2NhbGluZ1xyXG4gIEBpZiB1bml0KCRiYXNlKSA9PSAncmVtJyB7XHJcbiAgICAkYmFzZTogc3RyaXAtdW5pdCgkYmFzZSkgKiAxNnB4O1xyXG4gIH1cclxuXHJcbiAgQGlmICRjb3VudCA9PSAxIHtcclxuICAgIEByZXR1cm4gLXpmLXRvLXJlbSgkdmFsdWVzLCAkYmFzZSk7XHJcbiAgfVxyXG5cclxuICBAZm9yICRpIGZyb20gMSB0aHJvdWdoICRjb3VudCB7XHJcbiAgICAkcmVtLXZhbHVlczogYXBwZW5kKCRyZW0tdmFsdWVzLCAtemYtdG8tcmVtKG50aCgkdmFsdWVzLCAkaSksICRiYXNlKSk7XHJcbiAgfVxyXG5cclxuICBAcmV0dXJuICRyZW0tdmFsdWVzO1xyXG59XHJcblxyXG4vLyBDb252ZXJ0cyBhIHVuaXRsZXNzLCBwaXhlbCwgb3IgcmVtIHZhbHVlIHRvIGVtLCBmb3IgdXNlIGluIGJyZWFrcG9pbnRzLlxyXG5AZnVuY3Rpb24gLXpmLWJwLXRvLWVtKCR2YWx1ZSkge1xyXG4gIC8vIFBpeGVsIGFuZCB1bml0bGVzcyB2YWx1ZXMgYXJlIGNvbnZlcnRlZCB0byByZW1zXHJcbiAgQGlmIHVuaXQoJHZhbHVlKSA9PSAncHgnIG9yIHVuaXRsZXNzKCR2YWx1ZSkge1xyXG4gICAgJHZhbHVlOiByZW0tY2FsYygkdmFsdWUsICRiYXNlOiAxNnB4KTtcclxuICB9XHJcblxyXG4gIC8vIFRoZW4gdGhlIHZhbHVlIGlzIGNvbnZlcnRlZCB0byBlbXNcclxuICBAcmV0dXJuIHN0cmlwLXVuaXQoJHZhbHVlKSAqIDFlbTtcclxufVxyXG5cclxuLy8vIENvbnZlcnRzIGEgcGl4ZWwgdmFsdWUgdG8gbWF0Y2hpbmcgcmVtIHZhbHVlLiAqQW55KiB2YWx1ZSBwYXNzZWQsIHJlZ2FyZGxlc3Mgb2YgdW5pdCwgaXMgYXNzdW1lZCB0byBiZSBhIHBpeGVsIHZhbHVlLiBCeSBkZWZhdWx0LCB0aGUgYmFzZSBwaXhlbCB2YWx1ZSB1c2VkIHRvIGNhbGN1bGF0ZSB0aGUgcmVtIHZhbHVlIGlzIHRha2VuIGZyb20gdGhlIGAkZ2xvYmFsLWZvbnQtc2l6ZWAgdmFyaWFibGUuXHJcbi8vLyBAYWNjZXNzIHByaXZhdGVcclxuLy8vXHJcbi8vLyBAcGFyYW0ge051bWJlcn0gJHZhbHVlIC0gUGl4ZWwgdmFsdWUgdG8gY29udmVydC5cclxuLy8vIEBwYXJhbSB7TnVtYmVyfSAkYmFzZSBbbnVsbF0gLSBCYXNlIGZvciBwaXhlbCBjb252ZXJzaW9uLlxyXG4vLy9cclxuLy8vIEByZXR1cm5zIHtOdW1iZXJ9IEEgbnVtYmVyIGluIHJlbXMsIGNhbGN1bGF0ZWQgYmFzZWQgb24gdGhlIGdpdmVuIHZhbHVlIGFuZCB0aGUgYmFzZSBwaXhlbCB2YWx1ZS4gcmVtIHZhbHVlcyBhcmUgcGFzc2VkIHRocm91Z2ggYXMgaXMuXHJcbkBmdW5jdGlvbiAtemYtdG8tcmVtKCR2YWx1ZSwgJGJhc2U6IG51bGwpIHtcclxuICAvLyBDaGVjayBpZiB0aGUgdmFsdWUgaXMgYSBudW1iZXJcclxuICBAaWYgdHlwZS1vZigkdmFsdWUpICE9ICdudW1iZXInIHtcclxuICAgIEB3YXJuIGluc3BlY3QoJHZhbHVlKSArICcgd2FzIHBhc3NlZCB0byByZW0tY2FsYygpLCB3aGljaCBpcyBub3QgYSBudW1iZXIuJztcclxuICAgIEByZXR1cm4gJHZhbHVlO1xyXG4gIH1cclxuXHJcbiAgLy8gVHJhbnNmb3JtIGVtIGludG8gcmVtIGlmIHNvbWVvbmUgaGFuZHMgb3ZlciAnZW0nc1xyXG4gIEBpZiB1bml0KCR2YWx1ZSkgPT0gJ2VtJyB7XHJcbiAgICAkdmFsdWU6IHN0cmlwLXVuaXQoJHZhbHVlKSAqIDFyZW07XHJcbiAgfVxyXG5cclxuICAvLyBDYWxjdWxhdGUgcmVtIGlmIHVuaXRzIGZvciAkdmFsdWUgaXMgbm90IHJlbSBvciBlbVxyXG4gIEBpZiB1bml0KCR2YWx1ZSkgIT0gJ3JlbScge1xyXG4gICAgJHZhbHVlOiBzdHJpcC11bml0KCR2YWx1ZSkgLyBzdHJpcC11bml0KCRiYXNlKSAqIDFyZW07XHJcbiAgfVxyXG5cclxuICAvLyBUdXJuIDByZW0gaW50byAwXHJcbiAgQGlmICR2YWx1ZSA9PSAwcmVtIHtcclxuICAgICR2YWx1ZTogMDtcclxuICB9XHJcblxyXG4gIEByZXR1cm4gJHZhbHVlO1xyXG59XHJcblxyXG4vLy8gQ29udmVydHMgYSBwaXhlbCwgcGVyY2VudGFnZSwgcmVtIG9yIGVtIHZhbHVlIHRvIGEgdW5pdGxlc3MgdmFsdWUgYmFzZWQgb24gYSBnaXZlbiBmb250IHNpemUuIElkZWFsIGZvciB3b3JraW5nIG91dCB1bml0bGVzcyBsaW5lIGhlaWdodHMuXHJcbi8vL1xyXG4vLy8gQHBhcmFtIHtOdW1iZXJ9ICR2YWx1ZSAtIFZhbHVlIHRvIGNvbnZlcnQgdG8gYSB1bml0bGVzcyBsaW5lIGhlaWdodFxyXG4vLy8gQHBhcmFtIHtOdW1iZXJ9ICRiYXNlIC0gVGhlIGZvbnQgc2l6ZSB0byB1c2UgdG8gd29yayBvdXQgdGhlIGxpbmUgaGVpZ2h0IC0gZGVmYXVsdHMgdG8gJGdsb2JhbC1mb250LXNpemVcclxuLy8vXHJcbi8vLyBAcmV0dXJuIHtOdW1iZXJ9IC0gVW5pdGxlc3MgbnVtYmVyXHJcbkBmdW5jdGlvbiB1bml0bGVzcy1jYWxjKCR2YWx1ZSwgJGJhc2U6IG51bGwpIHtcclxuXHJcbiAgLy8gSWYgbm8gYmFzZSBpcyBkZWZpbmVkLCBkZWZlciB0byB0aGUgZ2xvYmFsIGZvbnQgc2l6ZVxyXG4gIEBpZiAkYmFzZSA9PSBudWxsIHtcclxuICAgICRiYXNlOiAkZ2xvYmFsLWZvbnQtc2l6ZTtcclxuICB9XHJcblxyXG4gIC8vIEZpcnN0LCBsZXRzIGNvbnZlcnQgb3VyICRiYXNlIHRvIHBpeGVsc1xyXG5cclxuICAvLyBJZiB0aGUgYmFzZSBmb250IHNpemUgaXMgYSAlLCB0aGVuIG11bHRpcGx5IGl0IGJ5IDE2cHhcclxuICBAaWYgdW5pdCgkYmFzZSkgPT0gJyUnIHtcclxuICAgICRiYXNlOiAoJGJhc2UgLyAxMDAlKSAqIDE2cHg7XHJcbiAgfVxyXG5cclxuICBAaWYgdW5pdCgkYmFzZSkgPT0gJ3JlbScge1xyXG4gICAgJGJhc2U6IHN0cmlwLXVuaXQoJGJhc2UpICogMTZweDtcclxuICB9XHJcblxyXG4gIEBpZiB1bml0KCRiYXNlKSA9PSAnZW0nIHtcclxuICAgICRiYXNlOiBzdHJpcC11bml0KCRiYXNlKSAqIDE2cHg7XHJcbiAgfVxyXG5cclxuICAvLyBOb3cgbGV0cyBjb252ZXJ0IG91ciB2YWx1ZSB0byBwaXhlbHMgdG9vXHJcbiAgQGlmIHVuaXQoJHZhbHVlKSA9PSAnJScge1xyXG4gICAgJHZhbHVlOiAoJHZhbHVlIC8gMTAwJSkgKiAkYmFzZTtcclxuICB9XHJcblxyXG4gIEBpZiB1bml0KCR2YWx1ZSkgPT0gJ3JlbScge1xyXG4gICAgJHZhbHVlOiBzdHJpcC11bml0KCR2YWx1ZSkgKiAkYmFzZTtcclxuICB9XHJcblxyXG4gIEBpZiB1bml0KCR2YWx1ZSkgPT0gJ2VtJyB7XHJcbiAgICAkdmFsdWU6IHN0cmlwLXVuaXQoJHZhbHVlKSAqICRiYXNlO1xyXG4gIH1cclxuXHJcbiAgLy8gJ3B4J1xyXG4gIEBpZiB1bml0KCR2YWx1ZSkgPT0gJ3B4JyB7XHJcbiAgICBAcmV0dXJuIHN0cmlwLXVuaXQoJHZhbHVlKSAvIHN0cmlwLXVuaXQoJGJhc2UpO1xyXG4gIH1cclxuXHJcbiAgLy8gYXNzdW1lIHRoYXQgbGluZS1oZWlnaHRzIGdyZWF0ZXJuIHRoZW4gMTAgYXJlIG1lYW50IHRvIGJlIGFic29sdXRlIGluICdweCdcclxuICBAaWYgdW5pdGxlc3MoJHZhbHVlKSBhbmQgKCR2YWx1ZSA+IDEwKSB7XHJcbiAgICBAcmV0dXJuICR2YWx1ZSAvIHN0cmlwLXVuaXQoJGJhc2UpO1xyXG4gIH1cclxuXHJcbiAgQHJldHVybiAkdmFsdWU7XHJcbn1cclxuIiwi77u/LyogU1RSSVAtVU5JVCBGVU5DVElPTlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbi8vIFJlbW92ZXMgdW5pdCBmcm9tIHZhbHVlLCBsZWF2ZXMgb25seSBhIG51bWJlci5cclxuLy8gSXQgaXMgdXNlZCBieSBSRU0tQ0FMQyBhbmQgb3RoZXIgZnVuY3Rpb25zLCBsaWtlIFBJWEVMQVRFLlxyXG5cclxuQGZ1bmN0aW9uIHN0cmlwLXVuaXQoJG51bWJlcikge1xyXG4gIEBpZiB0eXBlLW9mKCRudW1iZXIpID09ICdudW1iZXInIGFuZCBub3QgdW5pdGxlc3MoJG51bWJlcikge1xyXG4gICAgQHJldHVybiAkbnVtYmVyIC8gKCRudW1iZXIgKiAwICsgMSk7XHJcbiAgfVxyXG5cclxuICBAcmV0dXJuICRudW1iZXI7XHJcbn0iLCIvKiBCT1gtU0hBRE9XIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIGJveC1zaGFkb3coJHRvcCwgJGxlZnQsICRibHVyLCAkY29sb3IsICRpbnNldDogZmFsc2UpIHtcclxuICAgIEBpZiAkaW5zZXQge1xyXG4gICAgICAgIC13ZWJraXQtYm94LXNoYWRvdzppbnNldCAkdG9wICRsZWZ0ICRibHVyICRjb2xvcjtcclxuICAgICAgICAtbW96LWJveC1zaGFkb3c6aW5zZXQgJHRvcCAkbGVmdCAkYmx1ciAkY29sb3I7XHJcbiAgICAgICAgYm94LXNoYWRvdzppbnNldCAkdG9wICRsZWZ0ICRibHVyICRjb2xvcjtcclxuICAgIH0gQGVsc2Uge1xyXG4gICAgICAgIC13ZWJraXQtYm94LXNoYWRvdzogJHRvcCAkbGVmdCAkYmx1ciAkY29sb3I7XHJcbiAgICAgICAgLW1vei1ib3gtc2hhZG93OiAkdG9wICRsZWZ0ICRibHVyICRjb2xvcjtcclxuICAgICAgICBib3gtc2hhZG93OiAkdG9wICRsZWZ0ICRibHVyICRjb2xvcjtcclxuICAgIH1cclxufVxyXG5cclxuQG1peGluIHNoYWRvdy1mbGF0KCRjb2xvciwgJHNpemU6IDRweCwgJG9wYWNpdHk6IDEsICRyb3RhdGVkOiBmYWxzZSl7XHJcblxyXG4gICAgQGlmICgkcm90YXRlZCkge1xyXG4gICAgICAgIEBpbmNsdWRlIGJveC1zaGFkb3coJHNpemUqKC0xKSwgJHNpemUsIDAsIHJnYmEoJGNvbG9yLCAkb3BhY2l0eSkpO1xyXG4gICAgfVxyXG4gICAgQGVsc2Uge1xyXG4gICAgICAgIEBpbmNsdWRlIGJveC1zaGFkb3coMCwgJHNpemUsIDAsIHJnYmEoJGNvbG9yLCAkb3BhY2l0eSkpO1xyXG4gICAgfVxyXG59XHJcblxyXG5cclxuLyogQ0xBU1MgQ1JFQVRJT04gTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gc2hhZG93LWdlbmVyYXRvcigkYW1vdW50LCAkY29sb3IsICRzaGFkb3ctb3BhY2l0eTogMSwgJGludGVydmFsOiAycHgpIHtcclxuXHJcbiAgICBAZm9yICRpIGZyb20gMSB0aHJvdWdoICRhbW91bnQge1xyXG5cclxuICAgICAgICAkc2hhZG93LXNpemU6ICRpICogJGludGVydmFsO1xyXG5cclxuICAgICAgICAlc2hhZG93LS1mbGF0X18jeyRpfSB7XHJcbiAgICAgICAgICAgIEBpbmNsdWRlIHNoYWRvdy1mbGF0KCRjb2xvciwgJHNpemU6ICRzaGFkb3ctc2l6ZSwgJG9wYWNpdHk6ICRzaGFkb3ctb3BhY2l0eSwgJHJvdGF0ZWQ6IGZhbHNlKTtcclxuICAgICAgICB9XHJcbiAgICAgICAgJXNoYWRvdy0tZmxhdC1yb3RhdGVkX18jeyRpfSB7XHJcbiAgICAgICAgICAgIEBpbmNsdWRlIHNoYWRvdy1mbGF0KCRjb2xvciwgJHNpemU6ICRzaGFkb3ctc2l6ZSwgJG9wYWNpdHk6ICRzaGFkb3ctb3BhY2l0eSwgJHJvdGF0ZWQ6IHRydWUpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufSIsIu+7vy8qIEZPTlQgTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gZm9udCgkc2l6ZTogZmFsc2UsICRjb2xvcjogZmFsc2UsICRmYW1pbHk6IGluaGVyaXQsICR0cmFuc2Zvcm06IGZhbHNlLCAgJGxoOiBmYWxzZSwgJHNwYWNpbmc6IGZhbHNlLCAkc3R5bGU6IGZhbHNlKSB7XHJcbiAgICBAaWYgJGZhbWlseSB7IFxyXG4gICAgICAgIGZvbnQtZmFtaWx5OiAkZm9udC1kZWZpbml0aW9uO1xyXG4gICAgICAgIGZvbnQtd2VpZ2h0OiBjaG9vc2UtZm9udCgkZm9udHMsICRmYW1pbHkpO1xyXG4gICAgfVxyXG4gICAgQGlmICRzaXplIHsgZm9udC1zaXplOiByZW0tY2FsYygkc2l6ZSk7IH1cclxuICAgIEBpZiAkY29sb3IgeyBjb2xvcjogJGNvbG9yOyB9XHJcbiAgICBAaWYgJHRyYW5zZm9ybSB7IHRleHQtdHJhbnNmb3JtOiAkdHJhbnNmb3JtOyB9XHJcbiAgICBAaWYgJHN0eWxlIHtmb250LXN0eWxlOiAkc3R5bGU7IH1cclxuICAgIEBpZiAkbGggeyBsaW5lLWhlaWdodDogcmVtLWNhbGMoJGxoKTsgfVxyXG4gICAgQGlmICRzcGFjaW5nIHsgbGV0dGVyLXNwYWNpbmc6IHJlbS1jYWxjKCRzcGFjaW5nKTsgfVxyXG59XHJcblxyXG5cclxuLyogQ0hPT1NFIEZPTlRcclxuICAgIEZ1bmN0aW9uIHRha2VzIGZvbnRzLCB0aGF0IGFyZSBpbiB2YXJpYWJsZSBhbmQgdGhhblxyXG4gICAgaXQgZ2l2ZXMgbmFtZSBvZiBwcm9wZXIgZm9udFxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcblxyXG5AZnVuY3Rpb24gY2hvb3NlLWZvbnQoJGZvbnRzLXZhcmlhYmxlLCAkZm9udCkge1xyXG5cclxuICAgIEBpZiAkZm9udCA9PSAnaW5oZXJpdCcge1xyXG4gICAgICAgIEByZXR1cm4gJGZvbnQ7XHJcbiAgICB9XHJcblxyXG4gICAgQGlmIG1hcC1oYXMta2V5KCRmb250cy12YXJpYWJsZSwgJGZvbnQpIHtcclxuICAgICAgICBAcmV0dXJuIG1hcC1nZXQoJGZvbnRzLXZhcmlhYmxlLCAkZm9udCk7XHJcbiAgICB9XHJcblxyXG4gICAgQGVsc2UgIHtcclxuICAgICAgICBAd2FybiBcIkZyYWplcnplLCBuaWUgbWEgdGFraWVnbyBmb250YSwgamFrICcjeyRmb250fSchIEd1cGlzP1wiO1xyXG4gICAgICAgIEByZXR1cm4gJGZvbnQ7XHJcbiAgICB9XHJcbn0iLCLvu78vKiBNQVJHSU4gTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gbWFyZ2luKCR2YWx1ZXMpIHtcclxuICAkbGVuZ3RoOiBsZW5ndGgoJHZhbHVlcyk7XHJcbiAgJHRvcDogbnRoKCR2YWx1ZXMsIDEpO1xyXG5cclxuICAgIEBpZiAkbGVuZ3RoID09IDEge1xyXG4gICAgICAgIG1hcmdpbjogY2hlY2tNYXJnaW4oJHRvcCk7XHJcbiAgICB9XHJcblxyXG4gICAgQGVsc2UgaWYgJGxlbmd0aCA9PSAyIHtcclxuICAgICAgICAkcmlnaHQ6IG50aCgkdmFsdWVzLCAyKTtcclxuICAgICAgICBtYXJnaW46IGNoZWNrTWFyZ2luKCR0b3ApIGNoZWNrTWFyZ2luKCRyaWdodCk7XHJcbiAgICB9XHJcblxyXG4gICAgQGVsc2UgaWYgJGxlbmd0aCA9PSAzIHtcclxuICAgICAgICAkcmlnaHQ6IG50aCgkdmFsdWVzLCAyKTtcclxuICAgICAgICAkYm90dG9tOiBudGgoJHZhbHVlcywgMyk7XHJcbiAgICAgICAgbWFyZ2luOiBjaGVja01hcmdpbigkdG9wKSBjaGVja01hcmdpbigkcmlnaHQpIGNoZWNrTWFyZ2luKCRib3R0b20pO1xyXG4gICAgfVxyXG5cclxuICAgIEBlbHNlIGlmICRsZW5ndGggPj0gNCB7XHJcbiAgICAgICAgJHJpZ2h0OiBudGgoJHZhbHVlcywgMik7XHJcbiAgICAgICAgJGJvdHRvbTogbnRoKCR2YWx1ZXMsIDMpO1xyXG4gICAgICAgICRsZWZ0OiBudGgoJHZhbHVlcywgNCk7XHJcbiAgICAgICAgbWFyZ2luOiBjaGVja01hcmdpbigkdG9wKSBjaGVja01hcmdpbigkcmlnaHQpIGNoZWNrTWFyZ2luKCRib3R0b20pIGNoZWNrTWFyZ2luKCRsZWZ0KTtcclxuICAgIH1cclxufVxyXG5cclxuQGZ1bmN0aW9uIGNoZWNrTWFyZ2luKCR2YWx1ZSl7XHJcbiAgICBAaWYoJHZhbHVlID09IGF1dG8pe1xyXG4gICAgICAgIEByZXR1cm4gJHZhbHVlO1xyXG4gICAgfVxyXG4gICAgQGVsc2V7XHJcbiAgICAgICAgQHJldHVybiByZW0tY2FsYygkdmFsdWUpO1xyXG4gICAgfVxyXG59XHJcbiIsIu+7vy8qIFBBRERJTkcgTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gcGFkZGluZygkdmFsdWVzKSB7XHJcbiAgJGxlbmd0aDogbGVuZ3RoKCR2YWx1ZXMpO1xyXG4gICR0b3A6IG50aCgkdmFsdWVzLCAxKTtcclxuXHJcbiAgICBAaWYgJGxlbmd0aCA9PSAxIHtcclxuICAgICAgICBwYWRkaW5nOiByZW0tY2FsYygkdG9wKTtcclxuICAgIH1cclxuIFxyXG4gICAgQGVsc2UgaWYgJGxlbmd0aCA9PSAyIHtcclxuICAgICAgICAkcmlnaHQ6IG50aCgkdmFsdWVzLCAyKTtcclxuICAgICAgICBwYWRkaW5nOiByZW0tY2FsYygkdG9wKSByZW0tY2FsYygkcmlnaHQpO1xyXG4gICAgfVxyXG5cclxuICAgIEBlbHNlIGlmICRsZW5ndGggPT0gMyB7XHJcbiAgICAgICAgJHJpZ2h0OiBudGgoJHZhbHVlcywgMik7XHJcbiAgICAgICAgJGJvdHRvbTogbnRoKCR2YWx1ZXMsIDMpO1xyXG4gICAgICAgIHBhZGRpbmc6IHJlbS1jYWxjKCR0b3ApIHJlbS1jYWxjKCRyaWdodCkgcmVtLWNhbGMoJGJvdHRvbSk7XHJcbiAgICB9XHJcblxyXG4gICAgQGVsc2UgaWYgJGxlbmd0aCA+PSA0IHtcclxuICAgICAgICAkcmlnaHQ6IG50aCgkdmFsdWVzLCAyKTtcclxuICAgICAgICAkYm90dG9tOiBudGgoJHZhbHVlcywgMyk7XHJcbiAgICAgICAgJGxlZnQ6IG50aCgkdmFsdWVzLCA0KTtcclxuICAgICAgICBwYWRkaW5nOiByZW0tY2FsYygkdG9wKSByZW0tY2FsYygkcmlnaHQpIHJlbS1jYWxjKCRib3R0b20pIHJlbS1jYWxjKCRsZWZ0KTtcclxuICAgIH1cclxufVxyXG4iLCIvKiBQT1NJVElPTiBNSVhJTlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiBwb3NpdGlvbigkcG9zaXRpb246IG51bGwsICR0b3A6IG51bGwsICRyaWdodDogbnVsbCwgJGJvdHRvbTogbnVsbCwgJGxlZnQ6IG51bGwpIHtcclxuICAgIHBvc2l0aW9uOiAkcG9zaXRpb247XHJcbiAgICB0b3A6ICR0b3A7XHJcbiAgICByaWdodDogJHJpZ2h0O1xyXG4gICAgYm90dG9tOiAkYm90dG9tO1xyXG4gICAgbGVmdDogJGxlZnQ7XHJcbn0iLCLvu78vKiBQU0VVRE8gRUxFTUVOVCBNSVhJTlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiBwc2V1ZG8oJGRpc3BsYXk6IGJsb2NrLCAkcG9zOiBhYnNvbHV0ZSwgJGNvbnRlbnQ6ICcnKXtcclxuICAgIGNvbnRlbnQ6ICRjb250ZW50O1xyXG4gICAgZGlzcGxheTogJGRpc3BsYXk7XHJcbiAgICBwb3NpdGlvbjogJHBvcztcclxufSIsIu+7vy8qIEJPUkRFUiBSQURJVVMgTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gcmFkaXVzKCRyYWRpdXM6IDVweCwgJGJnQ2xpcDogdHJ1ZSkge1xyXG4gICAgYm9yZGVyLXJhZGl1czogcmVtLWNhbGMoJHJhZGl1cyk7XHJcbiAgICBAaWYoJGJnQ2xpcCkge1xyXG4gICAgICAgIGJhY2tncm91bmQtY2xpcDogcGFkZGluZy1ib3g7XHJcbiAgICAgICAgLyogc3RvcHMgYmcgY29sb3IgZnJvbSBsZWFraW5nIG91dHNpZGUgdGhlIGJvcmRlcjogKi9cclxuICAgIH1cclxufSIsIi8qIEVMRU1FTlQgU0laRSBNSVhJTlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiBzaXplKCR3OiBudWxsLCAkaDogbnVsbCwgJHdOb1JlbTogZmFsc2UsICRoTm9SZW06IGZhbHNlKSB7XHJcbiAgICBAaWYgKCR3ICE9YXV0byBhbmQgJHcgIT1udWxsIGFuZCAkdyAhPWluaGVyaXQgYW5kICR3Tm9SZW0gIT10cnVlKSB7XHJcbiAgICAgICAgJHc6IHJlbS1jYWxjKCR3KVxyXG4gICAgfVxyXG4gICAgQGlmICgkaCAhPWF1dG8gYW5kICRoICE9bnVsbCBhbmQgJGggIT1pbmhlcml0IGFuZCAkaE5vUmVtICE9dHJ1ZSkge1xyXG4gICAgICAgICRoOiByZW0tY2FsYygkaClcclxuICAgIH1cclxuICAgIHdpZHRoOiAkdztcclxuICAgIGhlaWdodDogJGg7XHJcbn1cclxuXHJcbkBtaXhpbiBzaXplLXF1ZXJ5KCRtb2JpbGVMaXN0OiBudWxsLCAkZGVza3RvcExpc3Q6IG51bGwpIHtcclxuICAgIEBpZiAoJG1vYmlsZUxpc3QpIHtcclxuICAgICAgICAkc2l6ZXNMaXN0OiBnZXRTaXplRnJvbUxpc3QoJG1vYmlsZUxpc3QpO1xyXG4gICAgICAgIEBpbmNsdWRlIG1lZGlhKCc8PXRhYmxldCcpIHtcclxuICAgICAgICAgICAgQGluY2x1ZGUgc2l6ZShudGgoJHNpemVzTGlzdCwgMSksIG50aCgkc2l6ZXNMaXN0LCAyKSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG4gICAgQGlmICgkZGVza3RvcExpc3QpIHtcclxuICAgICAgICAkc2l6ZXNMaXN0OiBnZXRTaXplRnJvbUxpc3QoJGRlc2t0b3BMaXN0KTtcclxuICAgICAgICBAaW5jbHVkZSBtZWRpYSgnPmxhcHRvcCcsICc8PWRlc2t0b3AnKSB7XHJcbiAgICAgICAgICAgIEBpbmNsdWRlIHNpemUobnRoKCRzaXplc0xpc3QsIDEpLCBudGgoJHNpemVzTGlzdCwgMikpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG5cclxuQG1peGluIGhlaWdodCgkdmFsdWUpIHtcclxuICAgIEBpbmNsdWRlIHNpemUoJGg6ICR2YWx1ZSk7XHJcbn1cclxuXHJcbkBtaXhpbiB3aWR0aCgkdmFsdWUpIHtcclxuICAgIEBpbmNsdWRlIHNpemUoJHc6ICR2YWx1ZSk7XHJcbn1cclxuXHJcbkBmdW5jdGlvbiBnZXRTaXplRnJvbUxpc3QoJGxpc3QpIHtcclxuICAgIEBpZiAodHlwZS1vZigkbGlzdCk9PWxpc3QpIHtcclxuICAgICAgICBAcmV0dXJuICRsaXN0O1xyXG4gICAgfVxyXG4gICAgJHdpZHRoOiAkbGlzdDtcclxuICAgICRoZWlnaHQ6ICRsaXN0O1xyXG4gICAgQHJldHVybiAoJHdpZHRoLCAkaGVpZ2h0KTtcclxufVxyXG4iLCIvKiBUUkFOU0lUSU9OIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIHRyYW5zaXRpb24oJHByb3BlcnR5OiBhbGwsICRkdXJhdGlvbjogMC4ycywgJGRlbGF5OiBmYWxzZSwgJGVhc2luZzogZWFzZSkge1xyXG4gICAgdHJhbnNpdGlvbjogJHByb3BlcnR5ICRkdXJhdGlvbiAkZWFzaW5nO1xyXG4gICAgQGlmICRkZWxheSB7IHRyYW5zaXRpb24tZGVsYXk6ICRkZWxheTsgfVxyXG59IiwiLyogV09SRCBXUkFQIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIHdvcmR3cmFwKCkge1xyXG4gICAgd29yZC1icmVhazogYnJlYWstYWxsO1xyXG4gICAgd29yZC13cmFwOiBicmVhay13b3JkO1xyXG4gICAgd2hpdGUtc3BhY2U6IG5vcm1hbDtcclxufSIsIu+7vy8qIFotSU5ERVggTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AZnVuY3Rpb24gei1pbmRleCgka2V5KSB7XHJcbiAgQHJldHVybiBtYXAtZ2V0KCR6LWluZGV4LCAka2V5KTtcclxufVxyXG5cclxuQG1peGluIHotaW5kZXgoJGtleSkge1xyXG4gIHotaW5kZXg6IHotaW5kZXgoJGtleSk7XHJcbn0iLCLvu78vKiBPVkVSTEFZIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIG92ZXJsYXkge1xyXG4gICAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gICAgd2lkdGg6IDEwMCU7XHJcbiAgICBoZWlnaHQ6IDEwMCU7XHJcbiAgICB0b3A6IDA7XHJcbiAgICBsZWZ0OiAwO1xyXG59XHJcblxyXG5cclxuLyogVFJVTkNBVEUgTUlYSU5cclxuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSovXHJcblxyXG5AbWl4aW4gdHJ1bmNhdGUoJHRydW5jYXRpb24tYm91bmRhcnkpIHtcclxuICAgIG1heC13aWR0aDogcmVtLWNhbGMoJHRydW5jYXRpb24tYm91bmRhcnkpO1xyXG4gICAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcclxuICAgIG92ZXJmbG93OiBoaWRkZW47XHJcbiAgICB0ZXh0LW92ZXJmbG93OiBlbGxpcHNpcztcclxufVxyXG5cclxuQG1peGluIHRydW5jYXRlLW11bHRpcGxlLWxpbmVzKCRmb250LXNpemUsICRsaW5lLWhlaWdodCwgJGxpbmVzLCAkdHJ1bmNhdGlvbi1ib3VuZGFyeSwgJGZvbnQtY29sb3IsICRmb250LWZhbWlseTogUmVndWxhcikge1xyXG4gICAgZGlzcGxheTogYmxvY2s7XHJcbiAgICBkaXNwbGF5OiAtd2Via2l0LWJveDtcclxuXHJcbiAgICBAaW5jbHVkZSBmb250KCRjb2xvcjogJGZvbnQtY29sb3IsICRzaXplOiAkZm9udC1zaXplLCAkbGg6ICRsaW5lLWhlaWdodCokZm9udC1zaXplLCAkZmFtaWx5OiAkZm9udC1mYW1pbHkpO1xyXG4gICAgQGluY2x1ZGUgdHJ1bmNhdGUoJHRydW5jYXRpb24tYm91bmRhcnkpO1xyXG4gICAgd2hpdGUtc3BhY2U6IG5vcm1hbDtcclxuXHJcbiAgICBoZWlnaHQ6ICRmb250LXNpemUqJGxpbmUtaGVpZ2h0KiRsaW5lcztcclxuICAgIC13ZWJraXQtbGluZS1jbGFtcDogJGxpbmVzO1xyXG4gICAgLXdlYmtpdC1ib3gtb3JpZW50OiB2ZXJ0aWNhbDtcclxufVxyXG5cclxuXHJcbi8qIElOUFVUIFBMQUNFSE9MREVSIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIGlucHV0LXBsYWNlaG9sZGVyIHtcclxuICAgICYucGxhY2Vob2xkZXIgeyBAY29udGVudDsgfVxyXG4gICAgJjotbW96LXBsYWNlaG9sZGVyIHsgQGNvbnRlbnQ7IH1cclxuICAgICY6Oi1tb3otcGxhY2Vob2xkZXIgeyBAY29udGVudDsgfVxyXG4gICAgJjotbXMtaW5wdXQtcGxhY2Vob2xkZXIgeyBAY29udGVudDsgfVxyXG4gICAgJjo6LXdlYmtpdC1pbnB1dC1wbGFjZWhvbGRlciB7IEBjb250ZW50OyB9XHJcbn1cclxuXHJcblxyXG4vKiBSRVNQT05TSVZFIFJBVElPIE1JWElOXHJcbi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0qL1xyXG5cclxuQG1peGluIHJlc3BvbnNpdmUtcmF0aW8oJHgsJHksICRwc2V1ZG86IGZhbHNlKSB7XHJcbiAgICAkcGFkZGluZzogdW5xdW90ZSggKCAkeSAvICR4ICkgKiAxMDAgKyAnJScgKTtcclxuICAgIEBpZiAkcHNldWRvIHtcclxuICAgICAgICAmOmJlZm9yZSB7XHJcbiAgICAgICAgICAgIEBpbmNsdWRlIHBzZXVkbygkcG9zOiByZWxhdGl2ZSk7XHJcbiAgICAgICAgICAgIHdpZHRoOiAxMDAlO1xyXG4gICAgICAgICAgICBwYWRkaW5nLXRvcDogJHBhZGRpbmc7XHJcbiAgICAgICAgfVxyXG4gICAgfSBAZWxzZSB7XHJcbiAgICAgICAgcGFkZGluZy10b3A6ICRwYWRkaW5nO1xyXG4gICAgfVxyXG59XHJcblxyXG5cclxuLyogSEFSRFdBUkUgQUNDRUxFUkFURSBNSVhJTlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiBoYXJkd2FyZSgkYmFja2ZhY2U6IHRydWUsICRwZXJzcGVjdGl2ZTogMTAwMCkge1xyXG4gICAgQGlmICRiYWNrZmFjZSB7XHJcbiAgICAgICAgYmFja2ZhY2UtdmlzaWJpbGl0eTogaGlkZGVuO1xyXG4gICAgfVxyXG4gICAgcGVyc3BlY3RpdmU6ICRwZXJzcGVjdGl2ZTtcclxufVxyXG5cclxuXHJcbi8qIFVOT1JERVJFRCBMSVNUIFdJVEggTk8gQlVMTEVUU1xyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiB1bm9yZGVyZWQtbm8tYnVsbGV0cyB7XHJcbiAgICBkaXNwbGF5OiBibG9jaztcclxuICAgIGxpc3Qtc3R5bGU6IG5vbmU7XHJcbiAgICBAaW5jbHVkZSBtYXJnaW4oMCk7XHJcbiAgICBAaW5jbHVkZSBwYWRkaW5nKDApO1xyXG59XHJcblxyXG4vKiBDRU5UUkFMSVpFIENPTlRFTlQgSU5TSURFIERJVlxyXG4tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tKi9cclxuXHJcbkBtaXhpbiBjZW50cmFsaXplIHtcclxuICAgIEBpbmNsdWRlIGZsZXhib3g7XHJcbiAgICBAaW5jbHVkZSBmbGV4LWFsaWduKGNlbnRlcik7XHJcbiAgICBAaW5jbHVkZSBmbGV4LWp1c3QoY2VudGVyKTtcclxufVxyXG4iLCJAaW1wb3J0IFwidXRpbGl0aWVzXCI7XHJcblxyXG4uYXBwIHtcclxuICBkaXNwbGF5OiBmbGV4O1xyXG4gIG1pbi1oZWlnaHQ6IDEwMHZoO1xyXG5cclxuICAmX19tYWluIHtcclxuICAgICRsYXlvdXQtYnVmZmVyOiA1MHB4O1xyXG5cclxuICAgIEBpbmNsdWRlIGZsZXg7XHJcbiAgICBmbGV4OiBhdXRvO1xyXG4gICAgd2lkdGg6IGNhbGMoMTAwdncgLSAje3JlbS1jYWxjKCRzaWRlbWVudV9fc2l6ZS0tZnVsbCArICRsYXlvdXQtYnVmZmVyKX0pO1xyXG4gICAgQGluY2x1ZGUgcGFkZGluZygyMHB4IDI1cHggMzBweCk7XHJcbiAgICBAaW5jbHVkZSBtYXJnaW4oMCAwIDAgJHNpZGVtZW51X19zaXplLS1mdWxsKTtcclxuICB9XHJcblxyXG4gICZfX21lbnUge1xyXG4gICAgQGluY2x1ZGUgcG9zaXRpb24oZml4ZWQpO1xyXG4gICAgQGluY2x1ZGUgc2l6ZSgkdzogJHNpZGVtZW51X19zaXplLS1mdWxsLCAkaDogMTAwdmgsICRoTm9SZW06IHRydWUpO1xyXG4gIH1cclxufVxyXG4iLCIvLyBGbGV4Ym94IE1peGluc1xyXG4vLyBodHRwOi8vcGhpbGlwd2FsdG9uLmdpdGh1Yi5pby9zb2x2ZWQtYnktZmxleGJveC9cclxuLy8gaHR0cHM6Ly9naXRodWIuY29tL3BoaWxpcHdhbHRvbi9zb2x2ZWQtYnktZmxleGJveFxyXG4vLyBcclxuLy8gQ29weXJpZ2h0IChjKSAyMDEzIEJyaWFuIEZyYW5jb1xyXG4vL1xyXG4vLyBQZXJtaXNzaW9uIGlzIGhlcmVieSBncmFudGVkLCBmcmVlIG9mIGNoYXJnZSwgdG8gYW55IHBlcnNvbiBvYnRhaW5pbmcgYVxyXG4vLyBjb3B5IG9mIHRoaXMgc29mdHdhcmUgYW5kIGFzc29jaWF0ZWQgZG9jdW1lbnRhdGlvbiBmaWxlcyAodGhlXHJcbi8vIFwiU29mdHdhcmVcIiksIHRvIGRlYWwgaW4gdGhlIFNvZnR3YXJlIHdpdGhvdXQgcmVzdHJpY3Rpb24sIGluY2x1ZGluZ1xyXG4vLyB3aXRob3V0IGxpbWl0YXRpb24gdGhlIHJpZ2h0cyB0byB1c2UsIGNvcHksIG1vZGlmeSwgbWVyZ2UsIHB1Ymxpc2gsXHJcbi8vIGRpc3RyaWJ1dGUsIHN1YmxpY2Vuc2UsIGFuZC9vciBzZWxsIGNvcGllcyBvZiB0aGUgU29mdHdhcmUsIGFuZCB0b1xyXG4vLyBwZXJtaXQgcGVyc29ucyB0byB3aG9tIHRoZSBTb2Z0d2FyZSBpcyBmdXJuaXNoZWQgdG8gZG8gc28sIHN1YmplY3QgdG9cclxuLy8gdGhlIGZvbGxvd2luZyBjb25kaXRpb25zOlxyXG4vLyBUaGUgYWJvdmUgY29weXJpZ2h0IG5vdGljZSBhbmQgdGhpcyBwZXJtaXNzaW9uIG5vdGljZSBzaGFsbCBiZSBpbmNsdWRlZFxyXG4vLyBpbiBhbGwgY29waWVzIG9yIHN1YnN0YW50aWFsIHBvcnRpb25zIG9mIHRoZSBTb2Z0d2FyZS5cclxuLy8gVEhFIFNPRlRXQVJFIElTIFBST1ZJREVEIFwiQVMgSVNcIiwgV0lUSE9VVCBXQVJSQU5UWSBPRiBBTlkgS0lORCwgRVhQUkVTU1xyXG4vLyBPUiBJTVBMSUVELCBJTkNMVURJTkcgQlVUIE5PVCBMSU1JVEVEIFRPIFRIRSBXQVJSQU5USUVTIE9GXHJcbi8vIE1FUkNIQU5UQUJJTElUWSwgRklUTkVTUyBGT1IgQSBQQVJUSUNVTEFSIFBVUlBPU0UgQU5EIE5PTklORlJJTkdFTUVOVC5cclxuLy8gSU4gTk8gRVZFTlQgU0hBTEwgVEhFIEFVVEhPUlMgT1IgQ09QWVJJR0hUIEhPTERFUlMgQkUgTElBQkxFIEZPUiBBTllcclxuLy8gQ0xBSU0sIERBTUFHRVMgT1IgT1RIRVIgTElBQklMSVRZLCBXSEVUSEVSIElOIEFOIEFDVElPTiBPRiBDT05UUkFDVCxcclxuLy8gVE9SVCBPUiBPVEhFUldJU0UsIEFSSVNJTkcgRlJPTSwgT1VUIE9GIE9SIElOIENPTk5FQ1RJT04gV0lUSCBUSEVcclxuLy8gU09GVFdBUkUgT1IgVEhFIFVTRSBPUiBPVEhFUiBERUFMSU5HUyBJTiBUSEUgU09GVFdBUkUuXHJcbi8vXHJcbi8vIFRoaXMgaXMgYSBzZXQgb2YgbWl4aW5zIGZvciB0aG9zZSB3aG8gd2FudCB0byBtZXNzIGFyb3VuZCB3aXRoIGZsZXhib3hcclxuLy8gdXNpbmcgdGhlIG5hdGl2ZSBzdXBwb3J0IG9mIGN1cnJlbnQgYnJvd3NlcnMuIEZvciBmdWxsIHN1cHBvcnQgdGFibGVcclxuLy8gY2hlY2s6IGh0dHA6Ly9jYW5pdXNlLmNvbS9mbGV4Ym94XHJcbi8vXHJcbi8vIEJhc2ljYWxseSB0aGlzIHdpbGwgdXNlOlxyXG4vL1xyXG4vLyAqIEZhbGxiYWNrLCBvbGQgc3ludGF4IChJRTEwLCBtb2JpbGUgd2Via2l0IGJyb3dzZXJzIC0gbm8gd3JhcHBpbmcpXHJcbi8vICogRmluYWwgc3RhbmRhcmRzIHN5bnRheCAoRkYsIFNhZmFyaSwgQ2hyb21lLCBJRTExLCBPcGVyYSlcclxuLy9cclxuLy8gVGhpcyB3YXMgaW5zcGlyZWQgYnk6XHJcbi8vIFxyXG4vLyAqIGh0dHA6Ly9kZXYub3BlcmEuY29tL2FydGljbGVzL3ZpZXcvYWR2YW5jZWQtY3Jvc3MtYnJvd3Nlci1mbGV4Ym94L1xyXG4vLyBcclxuLy8gV2l0aCBoZWxwIGZyb206XHJcbi8vIFxyXG4vLyAqIGh0dHA6Ly93My5vcmcvdHIvY3NzMy1mbGV4Ym94L1xyXG4vLyAqIGh0dHA6Ly90aGUtZWNob3BsZXgubmV0L2ZsZXh5Ym94ZXMvXHJcbi8vICogaHR0cDovL21zZG4ubWljcm9zb2Z0LmNvbS9lbi11cy9saWJyYXJ5L2llL2hoNzcyMDY5KHY9dnMuODUpLmFzcHhcclxuLy8gKiBodHRwOi8vY3NzLXRyaWNrcy5jb20vdXNpbmctZmxleGJveC9cclxuLy8gKiBodHRwOi8vZGV2Lm9wZXJhLmNvbS9hcnRpY2xlcy92aWV3L2FkdmFuY2VkLWNyb3NzLWJyb3dzZXItZmxleGJveC9cclxuLy8gKiBodHRwczovL2RldmVsb3Blci5tb3ppbGxhLm9yZy9lbi11cy9kb2NzL3dlYi9ndWlkZS9jc3MvZmxleGlibGVfYm94ZXNcclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBDb250YWluZXJzXHJcbi8vXHJcbi8vIFRoZSAnZmxleCcgdmFsdWUgY2F1c2VzIGFuIGVsZW1lbnQgdG8gZ2VuZXJhdGUgYSBibG9jay1sZXZlbCBmbGV4XHJcbi8vIGNvbnRhaW5lciBib3guXHJcbi8vXHJcbi8vIFRoZSAnaW5saW5lLWZsZXgnIHZhbHVlIGNhdXNlcyBhbiBlbGVtZW50IHRvIGdlbmVyYXRlIGEgaW5saW5lLWxldmVsXHJcbi8vIGZsZXggY29udGFpbmVyIGJveC4gXHJcbi8vXHJcbi8vIGRpc3BsYXk6IGZsZXggfCBpbmxpbmUtZmxleFxyXG4vL1xyXG4vLyBodHRwOi8vdzMub3JnL3RyL2NzczMtZmxleGJveC8jZmxleC1jb250YWluZXJzXHJcbi8vXHJcbi8vIChQbGFjZWhvbGRlciBzZWxlY3RvcnMgZm9yIGVhY2ggdHlwZSwgZm9yIHRob3NlIHdobyByYXRoZXIgQGV4dGVuZClcclxuXHJcbkBtaXhpbiBmbGV4Ym94IHtcclxuXHRkaXNwbGF5OiAtd2Via2l0LWJveDtcclxuXHRkaXNwbGF5OiAtd2Via2l0LWZsZXg7XHJcblx0ZGlzcGxheTogLW1vei1mbGV4O1xyXG5cdGRpc3BsYXk6IC1tcy1mbGV4Ym94O1xyXG5cdGRpc3BsYXk6IGZsZXg7XHJcbn1cclxuXHJcbiVmbGV4Ym94IHsgQGluY2x1ZGUgZmxleGJveDsgfVxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcblxyXG5AbWl4aW4gaW5saW5lLWZsZXgge1xyXG5cdGRpc3BsYXk6IC13ZWJraXQtaW5saW5lLWJveDtcclxuXHRkaXNwbGF5OiAtd2Via2l0LWlubGluZS1mbGV4O1xyXG5cdGRpc3BsYXk6IC1tb3otaW5saW5lLWZsZXg7XHJcblx0ZGlzcGxheTogLW1zLWlubGluZS1mbGV4Ym94O1xyXG5cdGRpc3BsYXk6IGlubGluZS1mbGV4O1xyXG59XHJcblxyXG4laW5saW5lLWZsZXggeyBAaW5jbHVkZSBpbmxpbmUtZmxleDsgfVxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcblxyXG4vLyBGbGV4Ym94IERpcmVjdGlvblxyXG4vL1xyXG4vLyBUaGUgJ2ZsZXgtZGlyZWN0aW9uJyBwcm9wZXJ0eSBzcGVjaWZpZXMgaG93IGZsZXggaXRlbXMgYXJlIHBsYWNlZCBpblxyXG4vLyB0aGUgZmxleCBjb250YWluZXIsIGJ5IHNldHRpbmcgdGhlIGRpcmVjdGlvbiBvZiB0aGUgZmxleCBjb250YWluZXInc1xyXG4vLyBtYWluIGF4aXMuIFRoaXMgZGV0ZXJtaW5lcyB0aGUgZGlyZWN0aW9uIHRoYXQgZmxleCBpdGVtcyBhcmUgbGFpZCBvdXQgaW4uIFxyXG4vL1xyXG4vLyBWYWx1ZXM6IHJvdyB8IHJvdy1yZXZlcnNlIHwgY29sdW1uIHwgY29sdW1uLXJldmVyc2VcclxuLy8gRGVmYXVsdDogcm93XHJcbi8vXHJcbi8vIGh0dHA6Ly93My5vcmcvdHIvY3NzMy1mbGV4Ym94LyNmbGV4LWRpcmVjdGlvbi1wcm9wZXJ0eVxyXG5cclxuQG1peGluIGZsZXgtZGlyZWN0aW9uKCR2YWx1ZTogcm93KSB7XHJcblx0QGlmICR2YWx1ZSA9PSByb3ctcmV2ZXJzZSB7XHJcblx0XHQtd2Via2l0LWJveC1kaXJlY3Rpb246IHJldmVyc2U7XHJcblx0XHQtd2Via2l0LWJveC1vcmllbnQ6IGhvcml6b250YWw7XHJcblx0fSBAZWxzZSBpZiAkdmFsdWUgPT0gY29sdW1uIHtcclxuXHRcdC13ZWJraXQtYm94LWRpcmVjdGlvbjogbm9ybWFsO1xyXG5cdFx0LXdlYmtpdC1ib3gtb3JpZW50OiB2ZXJ0aWNhbDtcclxuXHR9IEBlbHNlIGlmICR2YWx1ZSA9PSBjb2x1bW4tcmV2ZXJzZSB7XHJcblx0XHQtd2Via2l0LWJveC1kaXJlY3Rpb246IHJldmVyc2U7XHJcblx0XHQtd2Via2l0LWJveC1vcmllbnQ6IHZlcnRpY2FsO1xyXG5cdH0gQGVsc2Uge1xyXG5cdFx0LXdlYmtpdC1ib3gtZGlyZWN0aW9uOiBub3JtYWw7XHJcblx0XHQtd2Via2l0LWJveC1vcmllbnQ6IGhvcml6b250YWw7XHJcblx0fVxyXG5cdC13ZWJraXQtZmxleC1kaXJlY3Rpb246ICR2YWx1ZTtcclxuXHQtbW96LWZsZXgtZGlyZWN0aW9uOiAkdmFsdWU7XHJcblx0LW1zLWZsZXgtZGlyZWN0aW9uOiAkdmFsdWU7XHJcblx0ZmxleC1kaXJlY3Rpb246ICR2YWx1ZTtcclxufVxyXG5cdC8vIFNob3J0ZXIgdmVyc2lvbjpcclxuXHRAbWl4aW4gZmxleC1kaXIoJGFyZ3MuLi4pIHsgQGluY2x1ZGUgZmxleC1kaXJlY3Rpb24oJGFyZ3MuLi4pOyB9XHJcblxyXG4vLy0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS1cclxuXHJcbi8vIEZsZXhib3ggV3JhcFxyXG4vL1xyXG4vLyBUaGUgJ2ZsZXgtd3JhcCcgcHJvcGVydHkgY29udHJvbHMgd2hldGhlciB0aGUgZmxleCBjb250YWluZXIgaXMgc2luZ2xlLWxpbmVcclxuLy8gb3IgbXVsdGktbGluZSwgYW5kIHRoZSBkaXJlY3Rpb24gb2YgdGhlIGNyb3NzLWF4aXMsIHdoaWNoIGRldGVybWluZXNcclxuLy8gdGhlIGRpcmVjdGlvbiBuZXcgbGluZXMgYXJlIHN0YWNrZWQgaW4uIFxyXG4vL1xyXG4vLyBWYWx1ZXM6IG5vd3JhcCB8IHdyYXAgfCB3cmFwLXJldmVyc2VcclxuLy8gRGVmYXVsdDogbm93cmFwXHJcbi8vXHJcbi8vIGh0dHA6Ly93My5vcmcvdHIvY3NzMy1mbGV4Ym94LyNmbGV4LXdyYXAtcHJvcGVydHlcclxuXHJcbkBtaXhpbiBmbGV4LXdyYXAoJHZhbHVlOiBub3dyYXApIHtcclxuXHQvLyBObyBXZWJraXQgQm94IGZhbGxiYWNrLlxyXG5cdC13ZWJraXQtZmxleC13cmFwOiAkdmFsdWU7XHJcblx0LW1vei1mbGV4LXdyYXA6ICR2YWx1ZTtcclxuXHRAaWYgJHZhbHVlID09IG5vd3JhcCB7XHJcblx0XHQtbXMtZmxleC13cmFwOiBub25lO1xyXG5cdH0gQGVsc2UgeyBcclxuXHRcdC1tcy1mbGV4LXdyYXA6ICR2YWx1ZTsgXHJcblx0fVxyXG5cdGZsZXgtd3JhcDogJHZhbHVlO1xyXG59XHJcblxyXG4vLy0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS1cclxuXHJcbi8vIEZsZXhib3ggRmxvdyAoc2hvcnRoYW5kKVxyXG4vL1xyXG4vLyBUaGUgJ2ZsZXgtZmxvdycgcHJvcGVydHkgaXMgYSBzaG9ydGhhbmQgZm9yIHNldHRpbmcgdGhlICdmbGV4LWRpcmVjdGlvbidcclxuLy8gYW5kICdmbGV4LXdyYXAnIHByb3BlcnRpZXMsIHdoaWNoIHRvZ2V0aGVyIGRlZmluZSB0aGUgZmxleCBjb250YWluZXInc1xyXG4vLyBtYWluIGFuZCBjcm9zcyBheGVzLlxyXG4vL1xyXG4vLyBWYWx1ZXM6IDxmbGV4LWRpcmVjdGlvbj4gfCA8ZmxleC13cmFwPiBcclxuLy8gRGVmYXVsdDogcm93IG5vd3JhcFxyXG4vL1xyXG4vLyBodHRwOi8vdzMub3JnL3RyL2NzczMtZmxleGJveC8jZmxleC1mbG93LXByb3BlcnR5XHJcblxyXG5AbWl4aW4gZmxleC1mbG93KCR2YWx1ZXM6IChyb3cgbm93cmFwKSkge1xyXG5cdC8vIE5vIFdlYmtpdCBCb3ggZmFsbGJhY2suXHJcblx0LXdlYmtpdC1mbGV4LWZsb3c6ICR2YWx1ZXM7XHJcblx0LW1vei1mbGV4LWZsb3c6ICR2YWx1ZXM7XHJcblx0LW1zLWZsZXgtZmxvdzogJHZhbHVlcztcclxuXHRmbGV4LWZsb3c6ICR2YWx1ZXM7XHJcbn1cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBPcmRlclxyXG4vL1xyXG4vLyBUaGUgJ29yZGVyJyBwcm9wZXJ0eSBjb250cm9scyB0aGUgb3JkZXIgaW4gd2hpY2ggZmxleCBpdGVtcyBhcHBlYXIgd2l0aGluXHJcbi8vIHRoZWlyIGZsZXggY29udGFpbmVyLCBieSBhc3NpZ25pbmcgdGhlbSB0byBvcmRpbmFsIGdyb3Vwcy5cclxuLy9cclxuLy8gRGVmYXVsdDogMFxyXG4vL1xyXG4vLyBodHRwOi8vdzMub3JnL3RyL2NzczMtZmxleGJveC8jb3JkZXItcHJvcGVydHlcclxuXHJcbkBtaXhpbiBvcmRlcigkaW50OiAwKSB7XHJcblx0LXdlYmtpdC1ib3gtb3JkaW5hbC1ncm91cDogJGludCArIDE7XHJcblx0LXdlYmtpdC1vcmRlcjogJGludDtcclxuXHQtbW96LW9yZGVyOiAkaW50O1xyXG5cdC1tcy1mbGV4LW9yZGVyOiAkaW50O1xyXG5cdG9yZGVyOiAkaW50O1xyXG59XHJcblxyXG4vLyBTaG9ydGVyIHZlcnNpb246XHJcbkBtaXhpbiBmbGV4LW9yZGVyKCRhcmdzLi4uKSB7IEBpbmNsdWRlIG9yZGVyKCRhcmdzLi4uKTsgfVxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcblxyXG4vLyBGbGV4Ym94IEdyb3dcclxuLy9cclxuLy8gVGhlICdmbGV4LWdyb3cnIHByb3BlcnR5IHNldHMgdGhlIGZsZXggZ3JvdyBmYWN0b3IuIE5lZ2F0aXZlIG51bWJlcnNcclxuLy8gYXJlIGludmFsaWQuXHJcbi8vXHJcbi8vIERlZmF1bHQ6IDBcclxuLy9cclxuLy8gaHR0cDovL3czLm9yZy90ci9jc3MzLWZsZXhib3gvI2ZsZXgtZ3Jvdy1wcm9wZXJ0eVxyXG5cclxuQG1peGluIGZsZXgtZ3JvdygkaW50OiAwKSB7XHJcblx0LXdlYmtpdC1ib3gtZmxleDogJGludDtcclxuXHQtd2Via2l0LWZsZXgtZ3JvdzogJGludDtcclxuXHQtbW96LWZsZXgtZ3JvdzogJGludDtcclxuXHQtbXMtZmxleC1wb3NpdGl2ZTogJGludDtcclxuXHRmbGV4LWdyb3c6ICRpbnQ7XHJcbn1cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBTaHJpbmtcclxuLy9cclxuLy8gVGhlICdmbGV4LXNocmluaycgcHJvcGVydHkgc2V0cyB0aGUgZmxleCBzaHJpbmsgZmFjdG9yLiBOZWdhdGl2ZSBudW1iZXJzXHJcbi8vIGFyZSBpbnZhbGlkLlxyXG4vL1xyXG4vLyBEZWZhdWx0OiAxXHJcbi8vXHJcbi8vIGh0dHA6Ly93My5vcmcvdHIvY3NzMy1mbGV4Ym94LyNmbGV4LXNocmluay1wcm9wZXJ0eVxyXG5cclxuQG1peGluIGZsZXgtc2hyaW5rKCRpbnQ6IDEpIHtcclxuXHQtd2Via2l0LWZsZXgtc2hyaW5rOiAkaW50O1xyXG5cdC1tb3otZmxleC1zaHJpbms6ICRpbnQ7XHJcblx0LW1zLWZsZXgtbmVnYXRpdmU6ICRpbnQ7XHJcblx0ZmxleC1zaHJpbms6ICRpbnQ7XHJcbn1cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBCYXNpc1xyXG4vL1xyXG4vLyBUaGUgJ2ZsZXgtYmFzaXMnIHByb3BlcnR5IHNldHMgdGhlIGZsZXggYmFzaXMuIE5lZ2F0aXZlIGxlbmd0aHMgYXJlIGludmFsaWQuIFxyXG4vL1xyXG4vLyBWYWx1ZXM6IExpa2UgXCJ3aWR0aFwiIFxyXG4vLyBEZWZhdWx0OiBhdXRvXHJcbi8vXHJcbi8vIGh0dHA6Ly93d3cudzMub3JnL1RSL2NzczMtZmxleGJveC8jZmxleC1iYXNpcy1wcm9wZXJ0eVxyXG5cclxuQG1peGluIGZsZXgtYmFzaXMoJHZhbHVlOiBhdXRvKSB7XHJcblx0LXdlYmtpdC1mbGV4LWJhc2lzOiAkdmFsdWU7XHJcblx0LW1vei1mbGV4LWJhc2lzOiAkdmFsdWU7XHJcblx0LW1zLWZsZXgtcHJlZmVycmVkLXNpemU6ICR2YWx1ZTtcclxuXHRmbGV4LWJhc2lzOiAkdmFsdWU7XHJcbn1cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBcIkZsZXhcIiAoc2hvcnRoYW5kKVxyXG4vL1xyXG4vLyBUaGUgJ2ZsZXgnIHByb3BlcnR5IHNwZWNpZmllcyB0aGUgY29tcG9uZW50cyBvZiBhIGZsZXhpYmxlIGxlbmd0aDogdGhlXHJcbi8vIGZsZXggZ3JvdyBmYWN0b3IgYW5kIGZsZXggc2hyaW5rIGZhY3RvciwgYW5kIHRoZSBmbGV4IGJhc2lzLiBXaGVuIGFuXHJcbi8vIGVsZW1lbnQgaXMgYSBmbGV4IGl0ZW0sICdmbGV4JyBpcyBjb25zdWx0ZWQgaW5zdGVhZCBvZiB0aGUgbWFpbiBzaXplXHJcbi8vIHByb3BlcnR5IHRvIGRldGVybWluZSB0aGUgbWFpbiBzaXplIG9mIHRoZSBlbGVtZW50LiBJZiBhbiBlbGVtZW50IGlzXHJcbi8vIG5vdCBhIGZsZXggaXRlbSwgJ2ZsZXgnIGhhcyBubyBlZmZlY3QuXHJcbi8vXHJcbi8vIFZhbHVlczogbm9uZSB8IDxmbGV4LWdyb3c+IDxmbGV4LXNocmluaz4gfHwgPGZsZXgtYmFzaXM+XHJcbi8vIERlZmF1bHQ6IFNlZSBpbmRpdmlkdWFsIHByb3BlcnRpZXMgKDEgMSAwKS5cclxuLy9cclxuLy8gaHR0cDovL3czLm9yZy90ci9jc3MzLWZsZXhib3gvI2ZsZXgtcHJvcGVydHlcclxuXHJcbkBtaXhpbiBmbGV4KCRmZzogMSwgJGZzOiBudWxsLCAkZmI6IG51bGwpIHtcclxuICAgIFxyXG5cdC8vIFNldCBhIHZhcmlhYmxlIHRvIGJlIHVzZWQgYnkgYm94LWZsZXggcHJvcGVydGllc1xyXG5cdCRmZy1ib3hmbGV4OiAkZmc7XHJcblxyXG5cdC8vIEJveC1GbGV4IG9ubHkgc3VwcG9ydHMgYSBmbGV4LWdyb3cgdmFsdWUgc28gbGV0J3MgZ3JhYiB0aGVcclxuXHQvLyBmaXJzdCBpdGVtIGluIHRoZSBsaXN0IGFuZCBqdXN0IHJldHVybiB0aGF0LlxyXG5cdEBpZiB0eXBlLW9mKCRmZykgPT0gJ2xpc3QnIHtcclxuXHRcdCRmZy1ib3hmbGV4OiBudGgoJGZnLCAxKTtcclxuXHR9XHJcblxyXG5cdC13ZWJraXQtYm94LWZsZXg6ICRmZy1ib3hmbGV4O1xyXG5cdC13ZWJraXQtZmxleDogJGZnICRmcyAkZmI7XHJcblx0LW1vei1ib3gtZmxleDogJGZnLWJveGZsZXg7XHJcblx0LW1vei1mbGV4OiAkZmcgJGZzICRmYjtcclxuXHQtbXMtZmxleDogJGZnICRmcyAkZmI7XHJcblx0ZmxleDogJGZnICRmcyAkZmI7XHJcbn1cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuLy8gRmxleGJveCBKdXN0aWZ5IENvbnRlbnRcclxuLy9cclxuLy8gVGhlICdqdXN0aWZ5LWNvbnRlbnQnIHByb3BlcnR5IGFsaWducyBmbGV4IGl0ZW1zIGFsb25nIHRoZSBtYWluIGF4aXNcclxuLy8gb2YgdGhlIGN1cnJlbnQgbGluZSBvZiB0aGUgZmxleCBjb250YWluZXIuIFRoaXMgaXMgZG9uZSBhZnRlciBhbnkgZmxleGlibGVcclxuLy8gbGVuZ3RocyBhbmQgYW55IGF1dG8gbWFyZ2lucyBoYXZlIGJlZW4gcmVzb2x2ZWQuIFR5cGljYWxseSBpdCBoZWxwcyBkaXN0cmlidXRlXHJcbi8vIGV4dHJhIGZyZWUgc3BhY2UgbGVmdG92ZXIgd2hlbiBlaXRoZXIgYWxsIHRoZSBmbGV4IGl0ZW1zIG9uIGEgbGluZSBhcmVcclxuLy8gaW5mbGV4aWJsZSwgb3IgYXJlIGZsZXhpYmxlIGJ1dCBoYXZlIHJlYWNoZWQgdGhlaXIgbWF4aW11bSBzaXplLiBJdCBhbHNvXHJcbi8vIGV4ZXJ0cyBzb21lIGNvbnRyb2wgb3ZlciB0aGUgYWxpZ25tZW50IG9mIGl0ZW1zIHdoZW4gdGhleSBvdmVyZmxvdyB0aGUgbGluZS5cclxuLy9cclxuLy8gTm90ZTogJ3NwYWNlLSonIHZhbHVlcyBub3Qgc3VwcG9ydGVkIGluIG9sZGVyIHN5bnRheGVzLlxyXG4vL1xyXG4vLyBWYWx1ZXM6IGZsZXgtc3RhcnQgfCBmbGV4LWVuZCB8IGNlbnRlciB8IHNwYWNlLWJldHdlZW4gfCBzcGFjZS1hcm91bmRcclxuLy8gRGVmYXVsdDogZmxleC1zdGFydFxyXG4vL1xyXG4vLyBodHRwOi8vdzMub3JnL3RyL2NzczMtZmxleGJveC8janVzdGlmeS1jb250ZW50LXByb3BlcnR5XHJcblxyXG5AbWl4aW4ganVzdGlmeS1jb250ZW50KCR2YWx1ZTogZmxleC1zdGFydCkge1xyXG5cdEBpZiAkdmFsdWUgPT0gZmxleC1zdGFydCB7XHJcblx0XHQtd2Via2l0LWJveC1wYWNrOiBzdGFydDtcclxuXHRcdC1tcy1mbGV4LXBhY2s6IHN0YXJ0O1xyXG5cdH0gQGVsc2UgaWYgJHZhbHVlID09IGZsZXgtZW5kIHtcclxuXHRcdC13ZWJraXQtYm94LXBhY2s6IGVuZDtcclxuXHRcdC1tcy1mbGV4LXBhY2s6IGVuZDtcclxuXHR9IEBlbHNlIGlmICR2YWx1ZSA9PSBzcGFjZS1iZXR3ZWVuIHtcclxuXHRcdC13ZWJraXQtYm94LXBhY2s6IGp1c3RpZnk7XHJcblx0XHQtbXMtZmxleC1wYWNrOiBqdXN0aWZ5O1xyXG5cdH0gQGVsc2UgaWYgJHZhbHVlID09IHNwYWNlLWFyb3VuZCB7XHJcblx0XHQtbXMtZmxleC1wYWNrOiBkaXN0cmlidXRlO1x0XHRcclxuXHR9IEBlbHNlIHtcclxuXHRcdC13ZWJraXQtYm94LXBhY2s6ICR2YWx1ZTtcclxuXHRcdC1tcy1mbGV4LXBhY2s6ICR2YWx1ZTtcclxuXHR9XHJcblx0LXdlYmtpdC1qdXN0aWZ5LWNvbnRlbnQ6ICR2YWx1ZTtcclxuXHQtbW96LWp1c3RpZnktY29udGVudDogJHZhbHVlO1xyXG5cdGp1c3RpZnktY29udGVudDogJHZhbHVlO1xyXG59XHJcblx0Ly8gU2hvcnRlciB2ZXJzaW9uOlxyXG5cdEBtaXhpbiBmbGV4LWp1c3QoJGFyZ3MuLi4pIHsgQGluY2x1ZGUganVzdGlmeS1jb250ZW50KCRhcmdzLi4uKTsgfVxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcblxyXG4vLyBGbGV4Ym94IEFsaWduIEl0ZW1zXHJcbi8vXHJcbi8vIEZsZXggaXRlbXMgY2FuIGJlIGFsaWduZWQgaW4gdGhlIGNyb3NzIGF4aXMgb2YgdGhlIGN1cnJlbnQgbGluZSBvZiB0aGVcclxuLy8gZmxleCBjb250YWluZXIsIHNpbWlsYXIgdG8gJ2p1c3RpZnktY29udGVudCcgYnV0IGluIHRoZSBwZXJwZW5kaWN1bGFyXHJcbi8vIGRpcmVjdGlvbi4gJ2FsaWduLWl0ZW1zJyBzZXRzIHRoZSBkZWZhdWx0IGFsaWdubWVudCBmb3IgYWxsIG9mIHRoZSBmbGV4XHJcbi8vIGNvbnRhaW5lcidzIGl0ZW1zLCBpbmNsdWRpbmcgYW5vbnltb3VzIGZsZXggaXRlbXMuICdhbGlnbi1zZWxmJyBhbGxvd3NcclxuLy8gdGhpcyBkZWZhdWx0IGFsaWdubWVudCB0byBiZSBvdmVycmlkZGVuIGZvciBpbmRpdmlkdWFsIGZsZXggaXRlbXMuIChGb3JcclxuLy8gYW5vbnltb3VzIGZsZXggaXRlbXMsICdhbGlnbi1zZWxmJyBhbHdheXMgbWF0Y2hlcyB0aGUgdmFsdWUgb2YgJ2FsaWduLWl0ZW1zJ1xyXG4vLyBvbiB0aGVpciBhc3NvY2lhdGVkIGZsZXggY29udGFpbmVyLikgXHJcbi8vXHJcbi8vIFZhbHVlczogZmxleC1zdGFydCB8IGZsZXgtZW5kIHwgY2VudGVyIHwgYmFzZWxpbmUgfCBzdHJldGNoXHJcbi8vIERlZmF1bHQ6IHN0cmV0Y2hcclxuLy9cclxuLy8gaHR0cDovL3czLm9yZy90ci9jc3MzLWZsZXhib3gvI2FsaWduLWl0ZW1zLXByb3BlcnR5XHJcblxyXG5AbWl4aW4gYWxpZ24taXRlbXMoJHZhbHVlOiBzdHJldGNoKSB7XHJcblx0QGlmICR2YWx1ZSA9PSBmbGV4LXN0YXJ0IHtcclxuXHRcdC13ZWJraXQtYm94LWFsaWduOiBzdGFydDtcclxuXHRcdC1tcy1mbGV4LWFsaWduOiBzdGFydDtcclxuXHR9IEBlbHNlIGlmICR2YWx1ZSA9PSBmbGV4LWVuZCB7XHJcblx0XHQtd2Via2l0LWJveC1hbGlnbjogZW5kO1xyXG5cdFx0LW1zLWZsZXgtYWxpZ246IGVuZDtcclxuXHR9IEBlbHNlIHtcclxuXHRcdC13ZWJraXQtYm94LWFsaWduOiAkdmFsdWU7XHJcblx0XHQtbXMtZmxleC1hbGlnbjogJHZhbHVlO1xyXG5cdH1cclxuXHQtd2Via2l0LWFsaWduLWl0ZW1zOiAkdmFsdWU7XHJcblx0LW1vei1hbGlnbi1pdGVtczogJHZhbHVlO1xyXG5cdGFsaWduLWl0ZW1zOiAkdmFsdWU7XHJcbn1cclxuXHJcblxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcblxyXG4vLyBGbGV4Ym94IEFsaWduIFNlbGZcclxuLy9cclxuLy8gVmFsdWVzOiBhdXRvIHwgZmxleC1zdGFydCB8IGZsZXgtZW5kIHwgY2VudGVyIHwgYmFzZWxpbmUgfCBzdHJldGNoXHJcbi8vIERlZmF1bHQ6IGF1dG9cclxuXHJcbkBtaXhpbiBhbGlnbi1zZWxmKCR2YWx1ZTogYXV0bykge1xyXG5cdC8vIE5vIFdlYmtpdCBCb3ggRmFsbGJhY2suXHJcblx0LXdlYmtpdC1hbGlnbi1zZWxmOiAkdmFsdWU7XHJcblx0LW1vei1hbGlnbi1zZWxmOiAkdmFsdWU7XHJcblx0QGlmICR2YWx1ZSA9PSBmbGV4LXN0YXJ0IHtcclxuXHRcdC1tcy1mbGV4LWl0ZW0tYWxpZ246IHN0YXJ0O1xyXG5cdH0gQGVsc2UgaWYgJHZhbHVlID09IGZsZXgtZW5kIHtcclxuXHRcdC1tcy1mbGV4LWl0ZW0tYWxpZ246IGVuZDtcclxuXHR9IEBlbHNlIHtcclxuXHRcdC1tcy1mbGV4LWl0ZW0tYWxpZ246ICR2YWx1ZTtcclxuXHR9XHJcblx0YWxpZ24tc2VsZjogJHZhbHVlO1xyXG59XHJcblxyXG4vLy0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS1cclxuXHJcbi8vIEZsZXhib3ggQWxpZ24gQ29udGVudFxyXG4vL1xyXG4vLyBUaGUgJ2FsaWduLWNvbnRlbnQnIHByb3BlcnR5IGFsaWducyBhIGZsZXggY29udGFpbmVyJ3MgbGluZXMgd2l0aGluIHRoZVxyXG4vLyBmbGV4IGNvbnRhaW5lciB3aGVuIHRoZXJlIGlzIGV4dHJhIHNwYWNlIGluIHRoZSBjcm9zcy1heGlzLCBzaW1pbGFyIHRvXHJcbi8vIGhvdyAnanVzdGlmeS1jb250ZW50JyBhbGlnbnMgaW5kaXZpZHVhbCBpdGVtcyB3aXRoaW4gdGhlIG1haW4tYXhpcy4gTm90ZSxcclxuLy8gdGhpcyBwcm9wZXJ0eSBoYXMgbm8gZWZmZWN0IHdoZW4gdGhlIGZsZXhib3ggaGFzIG9ubHkgYSBzaW5nbGUgbGluZS5cclxuLy9cclxuLy8gVmFsdWVzOiBmbGV4LXN0YXJ0IHwgZmxleC1lbmQgfCBjZW50ZXIgfCBzcGFjZS1iZXR3ZWVuIHwgc3BhY2UtYXJvdW5kIHwgc3RyZXRjaFxyXG4vLyBEZWZhdWx0OiBzdHJldGNoXHJcbi8vXHJcbi8vIGh0dHA6Ly93My5vcmcvdHIvY3NzMy1mbGV4Ym94LyNhbGlnbi1jb250ZW50LXByb3BlcnR5XHJcblxyXG5AbWl4aW4gYWxpZ24tY29udGVudCgkdmFsdWU6IHN0cmV0Y2gpIHtcclxuXHQvLyBObyBXZWJraXQgQm94IEZhbGxiYWNrLlxyXG5cdC13ZWJraXQtYWxpZ24tY29udGVudDogJHZhbHVlO1xyXG5cdC1tb3otYWxpZ24tY29udGVudDogJHZhbHVlO1xyXG5cdEBpZiAkdmFsdWUgPT0gZmxleC1zdGFydCB7XHJcblx0XHQtbXMtZmxleC1saW5lLXBhY2s6IHN0YXJ0O1xyXG5cdH0gQGVsc2UgaWYgJHZhbHVlID09IGZsZXgtZW5kIHtcclxuXHRcdC1tcy1mbGV4LWxpbmUtcGFjazogZW5kO1xyXG5cdH0gQGVsc2Uge1xyXG5cdFx0LW1zLWZsZXgtbGluZS1wYWNrOiAkdmFsdWU7XHJcblx0fVxyXG5cdGFsaWduLWNvbnRlbnQ6ICR2YWx1ZTtcclxufVxyXG5cclxuLy8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcbi8vIEZsZXhib3ggYWxsIGFsaW5nc1xyXG5cclxuQG1peGluIGZsZXgtYWxpZ24oJGl0ZW1zOiBudWxsLCAkc2VsZjogbnVsbCwgJGNvbnRlbnQ6IG51bGwpe1xyXG4gICAgQGlmKCRpdGVtcyl7QGluY2x1ZGUgYWxpZ24taXRlbXMoJGl0ZW1zKX1cclxuICAgIEBpZigkc2VsZil7QGluY2x1ZGUgYWxpZ24tc2VsZigkc2VsZil9XHJcbiAgICBAaWYoJGNvbnRlbnQpe0BpbmNsdWRlIGFsaWduLXNlbGYoJGNvbnRlbnQpfVxyXG59Il19 */"

/***/ }),

/***/ "./src/app/modules/main/main.component.ts":
/*!************************************************!*\
  !*** ./src/app/modules/main/main.component.ts ***!
  \************************************************/
/*! exports provided: MainComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MainComponent", function() { return MainComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_side_menu_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./shared/side-menu.service */ "./src/app/modules/main/shared/side-menu.service.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");




var MainComponent = /** @class */ (function () {
    function MainComponent(sideMenuService) {
        this.sideMenuService = sideMenuService;
    }
    MainComponent.prototype.ngOnInit = function () {
        this.sideMenuService.setSidenav(this.sidenav);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('sidenav'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSidenav"])
    ], MainComponent.prototype, "sidenav", void 0);
    MainComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-main',
            template: __webpack_require__(/*! ./main.component.html */ "./src/app/modules/main/main.component.html"),
            styles: [__webpack_require__(/*! ./main.component.scss */ "./src/app/modules/main/main.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_side_menu_service__WEBPACK_IMPORTED_MODULE_2__["SideMenuService"]])
    ], MainComponent);
    return MainComponent;
}());



/***/ }),

/***/ "./src/app/modules/main/main.module.ts":
/*!*********************************************!*\
  !*** ./src/app/modules/main/main.module.ts ***!
  \*********************************************/
/*! exports provided: MainModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MainModule", function() { return MainModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _main_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./main.component */ "./src/app/modules/main/main.component.ts");
/* harmony import */ var _toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./toolbar/toolbar.component */ "./src/app/modules/main/toolbar/toolbar.component.ts");
/* harmony import */ var _side_menu_side_menu_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./side-menu/side-menu.component */ "./src/app/modules/main/side-menu/side-menu.component.ts");
/* harmony import */ var _shared_modules_material_material_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../shared/modules/material/material.module */ "./src/app/shared/modules/material/material.module.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");








var MainModule = /** @class */ (function () {
    function MainModule() {
    }
    MainModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_7__["RouterModule"],
                _shared_modules_material_material_module__WEBPACK_IMPORTED_MODULE_6__["MaterialModule"]
            ],
            exports: [_main_component__WEBPACK_IMPORTED_MODULE_3__["MainComponent"]],
            declarations: [
                _main_component__WEBPACK_IMPORTED_MODULE_3__["MainComponent"],
                _toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_4__["ToolbarComponent"],
                _side_menu_side_menu_component__WEBPACK_IMPORTED_MODULE_5__["SideMenuComponent"]
            ]
        })
    ], MainModule);
    return MainModule;
}());



/***/ }),

/***/ "./src/app/modules/main/shared/side-menu.service.ts":
/*!**********************************************************!*\
  !*** ./src/app/modules/main/shared/side-menu.service.ts ***!
  \**********************************************************/
/*! exports provided: SideMenuService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SideMenuService", function() { return SideMenuService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SideMenuService = /** @class */ (function () {
    function SideMenuService() {
    }
    SideMenuService.prototype.setSidenav = function (sidenav) {
        this.sidenav = sidenav;
    };
    SideMenuService.prototype.toggle = function () {
        this.sidenav.toggle();
    };
    SideMenuService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SideMenuService);
    return SideMenuService;
}());



/***/ }),

/***/ "./src/app/modules/main/side-menu/side-menu.component.html":
/*!*****************************************************************!*\
  !*** ./src/app/modules/main/side-menu/side-menu.component.html ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-nav-list>\n  <a mat-list-item routerLink=\"/recipients\">Recipients</a>\n</mat-nav-list>\n\n"

/***/ }),

/***/ "./src/app/modules/main/side-menu/side-menu.component.scss":
/*!*****************************************************************!*\
  !*** ./src/app/modules/main/side-menu/side-menu.component.scss ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9zaWRlLW1lbnUvc2lkZS1tZW51LmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/modules/main/side-menu/side-menu.component.ts":
/*!***************************************************************!*\
  !*** ./src/app/modules/main/side-menu/side-menu.component.ts ***!
  \***************************************************************/
/*! exports provided: SideMenuComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SideMenuComponent", function() { return SideMenuComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SideMenuComponent = /** @class */ (function () {
    function SideMenuComponent() {
    }
    SideMenuComponent.prototype.ngOnInit = function () {
    };
    SideMenuComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-side-menu',
            template: __webpack_require__(/*! ./side-menu.component.html */ "./src/app/modules/main/side-menu/side-menu.component.html"),
            styles: [__webpack_require__(/*! ./side-menu.component.scss */ "./src/app/modules/main/side-menu/side-menu.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SideMenuComponent);
    return SideMenuComponent;
}());



/***/ }),

/***/ "./src/app/modules/main/toolbar/toolbar.component.html":
/*!*************************************************************!*\
  !*** ./src/app/modules/main/toolbar/toolbar.component.html ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-toolbar>\n  <button mat-icon-button (click)=\"toggleSideMenu()\"><mat-icon>menu</mat-icon></button>\n  <h1>Home Expenses</h1>\n</mat-toolbar>\n"

/***/ }),

/***/ "./src/app/modules/main/toolbar/toolbar.component.scss":
/*!*************************************************************!*\
  !*** ./src/app/modules/main/toolbar/toolbar.component.scss ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi90b29sYmFyL3Rvb2xiYXIuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/modules/main/toolbar/toolbar.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/modules/main/toolbar/toolbar.component.ts ***!
  \***********************************************************/
/*! exports provided: ToolbarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolbarComponent", function() { return ToolbarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_side_menu_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../shared/side-menu.service */ "./src/app/modules/main/shared/side-menu.service.ts");



var ToolbarComponent = /** @class */ (function () {
    function ToolbarComponent(sideMenuService) {
        this.sideMenuService = sideMenuService;
    }
    ToolbarComponent.prototype.ngOnInit = function () {
    };
    ToolbarComponent.prototype.toggleSideMenu = function () {
        this.sideMenuService.toggle();
    };
    ToolbarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-toolbar',
            template: __webpack_require__(/*! ./toolbar.component.html */ "./src/app/modules/main/toolbar/toolbar.component.html"),
            styles: [__webpack_require__(/*! ./toolbar.component.scss */ "./src/app/modules/main/toolbar/toolbar.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_side_menu_service__WEBPACK_IMPORTED_MODULE_2__["SideMenuService"]])
    ], ToolbarComponent);
    return ToolbarComponent;
}());



/***/ }),

/***/ "./src/app/modules/recipients/recipients.component.html":
/*!**************************************************************!*\
  !*** ./src/app/modules/recipients/recipients.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  recipients works!\r\n</p>\r\n<!--<mat-list>-->\r\n  <!--<mat-list-item> List works! </mat-list-item>-->\r\n  <!--<mat-list-item> {{recipient.id}} </mat-list-item>-->\r\n  <!--<mat-list-item> {{recipient.name}} </mat-list-item>-->\r\n  <!--<mat-list-item> {{recipient.city}} </mat-list-item>-->\r\n  <!--<mat-list-item> {{recipient.street}} </mat-list-item>-->\r\n  <!--<mat-list-item> {{recipient.number}} </mat-list-item>-->\r\n<!--</mat-list>-->\r\n"

/***/ }),

/***/ "./src/app/modules/recipients/recipients.component.scss":
/*!**************************************************************!*\
  !*** ./src/app/modules/recipients/recipients.component.scss ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "table {\n  width: 100%; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9yZWNpcGllbnRzL0M6XFxVc2Vyc1xcdGRyenlcXHNvdXJjZVxccmVwb3NcXEhvbWVFeHBlbnNlc1xcSG9tZUV4cGVuc2VzLlVJXFxDbGllbnRBcHAvc3JjXFxhcHBcXG1vZHVsZXNcXHJlY2lwaWVudHNcXHJlY2lwaWVudHMuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxZQUFXLEVBQ1oiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL3JlY2lwaWVudHMvcmVjaXBpZW50cy5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbInRhYmxlIHtcclxuICB3aWR0aDogMTAwJTtcclxufVxyXG4iXX0= */"

/***/ }),

/***/ "./src/app/modules/recipients/recipients.component.ts":
/*!************************************************************!*\
  !*** ./src/app/modules/recipients/recipients.component.ts ***!
  \************************************************************/
/*! exports provided: RecipientsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RecipientsComponent", function() { return RecipientsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
/* harmony import */ var _shared_recipients_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./shared/recipients.service */ "./src/app/modules/recipients/shared/recipients.service.ts");





var RecipientsComponent = /** @class */ (function () {
    function RecipientsComponent(recipientsService) {
        this.recipientsService = recipientsService;
    }
    RecipientsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.recipientsService.getRecipients()
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["catchError"])(this.handleError))
            .subscribe(function (recipient) { return _this.recipient = recipient; });
    };
    RecipientsComponent.prototype.handleError = function (error) {
        if (error.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            console.error('An error occurred:', error.error.message);
        }
        else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            console.error("Backend returned code " + error.status + ", " +
                ("body was: " + error.error));
        }
        // return an observable with a user-facing error message
        return Object(rxjs__WEBPACK_IMPORTED_MODULE_2__["throwError"])('Something bad happened; please try again later.' + error.error.status);
    };
    ;
    RecipientsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-recipients',
            template: __webpack_require__(/*! ./recipients.component.html */ "./src/app/modules/recipients/recipients.component.html"),
            styles: [__webpack_require__(/*! ./recipients.component.scss */ "./src/app/modules/recipients/recipients.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_shared_recipients_service__WEBPACK_IMPORTED_MODULE_4__["RecipientsService"]])
    ], RecipientsComponent);
    return RecipientsComponent;
}());



/***/ }),

/***/ "./src/app/modules/recipients/recipients.module.ts":
/*!*********************************************************!*\
  !*** ./src/app/modules/recipients/recipients.module.ts ***!
  \*********************************************************/
/*! exports provided: RecipientsModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RecipientsModule", function() { return RecipientsModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_material_list__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material/list */ "./node_modules/@angular/material/esm5/list.es5.js");
/* harmony import */ var _recipients_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./recipients.component */ "./src/app/modules/recipients/recipients.component.ts");





var RecipientsModule = /** @class */ (function () {
    function RecipientsModule() {
    }
    RecipientsModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_material_list__WEBPACK_IMPORTED_MODULE_3__["MatListModule"]
            ],
            declarations: [
                _recipients_component__WEBPACK_IMPORTED_MODULE_4__["RecipientsComponent"]
            ],
            exports: [
                _recipients_component__WEBPACK_IMPORTED_MODULE_4__["RecipientsComponent"]
            ]
        })
    ], RecipientsModule);
    return RecipientsModule;
}());



/***/ }),

/***/ "./src/app/modules/recipients/shared/recipients.service.ts":
/*!*****************************************************************!*\
  !*** ./src/app/modules/recipients/shared/recipients.service.ts ***!
  \*****************************************************************/
/*! exports provided: RecipientsService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RecipientsService", function() { return RecipientsService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");



var RecipientsService = /** @class */ (function () {
    function RecipientsService(http) {
        this.http = http;
        this.path = 'http://localhost:60440/api/Recipients/F16CE11C-CA45-4449-A942-54F4B22106EA';
    }
    RecipientsService.prototype.getRecipients = function () {
        return this.http.get(this.path);
    };
    RecipientsService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"]])
    ], RecipientsService);
    return RecipientsService;
}());



/***/ }),

/***/ "./src/app/shared/modules/material/material.module.ts":
/*!************************************************************!*\
  !*** ./src/app/shared/modules/material/material.module.ts ***!
  \************************************************************/
/*! exports provided: MaterialModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MaterialModule", function() { return MaterialModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");




var MaterialModule = /** @class */ (function () {
    function MaterialModule() {
    }
    MaterialModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSidenavModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatToolbarModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatIconModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatMenuModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatListModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonToggleModule"]
            ],
            exports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSidenavModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatToolbarModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatIconModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatMenuModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatListModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonToggleModule"]
            ],
            declarations: []
        })
    ], MaterialModule);
    return MaterialModule;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * In development mode, for easier debugging, you can ignore zone related error
 * stack frames such as `zone.run`/`zoneDelegate.invokeTask` by importing the
 * below file. Don't forget to comment it out in production mode
 * because it will have a performance impact when errors are thrown
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\tdrzy\source\repos\HomeExpenses\HomeExpenses.UI\ClientApp\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map