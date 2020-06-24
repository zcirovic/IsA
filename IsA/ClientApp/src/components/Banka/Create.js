"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __spreadArrays = (this && this.__spreadArrays) || function () {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var react_router_dom_1 = require("react-router-dom");
var axios_1 = require("axios");
var Create = /** @class */ (function (_super) {
    __extends(Create, _super);
    function Create(props) {
        var _this = _super.call(this, props) || this;
        _this.processFormSubmission = function (e) {
            e.preventDefault();
            _this.setState({ loading: true });
            var formData = {
                first_name: _this.state.first_name,
                last_name: _this.state.last_name,
                email: _this.state.email,
                phone: _this.state.phone,
                address: _this.state.address,
                description: _this.state.description,
            };
            _this.setState({ submitSuccess: true, values: __spreadArrays(_this.state.values, [formData]), loading: false });
            axios_1.default.post("http://localhost:5000/customers", formData).then(function (data) { return [
                setTimeout(function () {
                    _this.props.history.push('/');
                }, 1500)
            ]; });
        };
        _this.handleInputChanges = function (e) {
            var _a;
            e.preventDefault();
            _this.setState((_a = {},
                _a[e.currentTarget.name] = e.currentTarget.value,
                _a));
        };
        _this.state = {
            first_name: '',
            last_name: '',
            email: '',
            phone: '',
            address: '',
            description: '',
            values: [],
            loading: false,
            submitSuccess: false,
        };
        return _this;
    }
    Create.prototype.render = function () {
        var _this = this;
        var _a = this.state, submitSuccess = _a.submitSuccess, loading = _a.loading;
        return (React.createElement("div", null,
            React.createElement("div", { className: "col-md-12 form-wrapper" },
                React.createElement("h2", null, " Create Post "),
                !submitSuccess && (React.createElement("div", { className: "alert alert-info", role: "alert" }, "Fill the form below to create a new post")),
                submitSuccess && (React.createElement("div", { className: "alert alert-info", role: "alert" }, "The form was successfully submitted!")),
                React.createElement("form", { id: "create-post-form", onSubmit: this.processFormSubmission, noValidate: true },
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "first_name" }, " First Name "),
                        React.createElement("input", { type: "text", id: "first_name", onChange: function (e) { return _this.handleInputChanges(e); }, name: "first_name", className: "form-control", placeholder: "Enter customer's first name" })),
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "last_name" }, " Last Name "),
                        React.createElement("input", { type: "text", id: "last_name", onChange: function (e) { return _this.handleInputChanges(e); }, name: "last_name", className: "form-control", placeholder: "Enter customer's last name" })),
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "email" }, " Email "),
                        React.createElement("input", { type: "email", id: "email", onChange: function (e) { return _this.handleInputChanges(e); }, name: "email", className: "form-control", placeholder: "Enter customer's email address" })),
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "phone" }, " Phone "),
                        React.createElement("input", { type: "text", id: "phone", onChange: function (e) { return _this.handleInputChanges(e); }, name: "phone", className: "form-control", placeholder: "Enter customer's phone number" })),
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "address" }, " Address "),
                        React.createElement("input", { type: "text", id: "address", onChange: function (e) { return _this.handleInputChanges(e); }, name: "address", className: "form-control", placeholder: "Enter customer's address" })),
                    React.createElement("div", { className: "form-group col-md-12" },
                        React.createElement("label", { htmlFor: "description" }, " Description "),
                        React.createElement("input", { type: "text", id: "description", onChange: function (e) { return _this.handleInputChanges(e); }, name: "description", className: "form-control", placeholder: "Enter Description" })),
                    React.createElement("div", { className: "form-group col-md-4 pull-right" },
                        React.createElement("button", { className: "btn btn-success", type: "submit" }, "Create Customer"),
                        loading &&
                            React.createElement("span", { className: "fa fa-circle-o-notch fa-spin" }))))));
    };
    return Create;
}(React.Component));
exports.default = react_router_dom_1.withRouter(Create);
//# sourceMappingURL=Create.js.map