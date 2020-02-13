'use strict';

angular.module('app')
    .controller('StaffCtrl', ['$scope', '$state', '$http', function ($scope, $state, $http){
        console.log('StaffCtrl loaded!');
        var _url = "/odata/Staffs";
        var vm = this;

        vm.model = {};
        vm.model.HasAccount = false;
        vm.toolbarTemplate = toolbarTemplate;
        vm.create = create;
        
        function create(){
            $state.go('app.staff.create');
        }

        function toolbarTemplate() {
            return kendo.template($("#toolbar").html());
        }

        $scope.mainGridOptions = {
            dataSource: {
                type: "odata-v4",
                transport: {
                    read: _url
                },
                pageSize: 5,
                serverPaging: true,
                serverSorting: true
            },
            sortable: true,
            pageable: true,
            height: 500,
            dataBound: function() {
                this.expandRow(this.tbody.find("tr.k-master-row").first());
            },
            columns: [
                {
                    field: "FullName",
                    title: "Full Name",
                    width: "50px"
                },
                {
                    field: "HasAccount",
                    title: "HasAccount",
                    width: "50px"
                },
                {
                    field: "Phone",
                    title: "Phone",
                    width: "50px"
                },
                {
                    field: "Email",
                    title: "Email",
                    width: "50px"
                },
                {
                    field: "Address",
                    title: "Address",
                    width: "80px"
                }
            ]
        };
}]);