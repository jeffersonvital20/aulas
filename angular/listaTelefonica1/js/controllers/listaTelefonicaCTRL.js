angular.module("listaTelefonica").controller("listaTelefonicaCTRL",function ($scope,$http){
$scope.app = "Lista Telefonica";

$scope.contatos = [];
$scope.operadoras = [];
var carregarContatos = function(){
	$http.get("http://localhost/lista/contatos.php").success(function(data){
		$scope.contatos = data;
	});
};

$scope.adicionarContato = function (contato){
	$scope.contatos.push(angular.copy(contato));
	delete $scope.contato;
	$scope.contatoForm.$setPristine();
}
$scope.apagarContato = function (contatos){
	$scope.contatos = contatos.filter(function (contato){
		if (!contato.selecionado) return contato;
	});
	$scope.contatoForm.setPristine();
};
$scope.isContatoSelecionado = function (contatos){
	return contatos.some(function (contato){
		return contato.selecionado;
	});
};
$scope.ordenarPor = function(campo){
	$scope.criterioDeOrdenacao = campo;
	$scope.direcaoDaOrdenacao = !$scope.direcaoDaOrdenacao;
}
carregarContatos();
});