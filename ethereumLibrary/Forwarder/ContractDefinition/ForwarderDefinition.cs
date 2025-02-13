﻿using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace ethereumLibrary.Forwarder.ContractDefinition
{
    public partial class ForwarderDeployment : ForwarderDeploymentBase
    {
        public ForwarderDeployment() : base(BYTECODE) { }
        public ForwarderDeployment(string byteCode) : base(byteCode) { }
    }

    public class ForwarderDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040526000805460ff60a01b1916905534801561001d57600080fd5b506000805460ff60a01b196001600160a01b0319909116331716600160a01b17905561050c8061004e6000396000f3fe6080604052600436106100595760003560e01c806319ab453c1461011a5780633ccfd60b1461014f5780633ef13367146101575780635e949fa01461018a5780636b9f96ea146101bd578063b269681d146101c557610115565b3661011557600080546040516001600160a01b03909116913480156108fc02929091818181858888f19350505050158015610098573d6000803e3d6000fd5b507f69b31548dea9b3b707b4dff357d326e3e9348b24e7a6080a218a6edeeec48f9b333460003660405180856001600160a01b03168152602001848152602001806020018281038252848482818152602001925080828437600083820152604051601f909101601f191690920182900397509095505050505050a1005b600080fd5b34801561012657600080fd5b5061014d6004803603602081101561013d57600080fd5b50356001600160a01b03166101f6565b005b61014d610235565b34801561016357600080fd5b5061014d6004803603602081101561017a57600080fd5b50356001600160a01b03166102ba565b34801561019657600080fd5b5061014d600480360360208110156101ad57600080fd5b50356001600160a01b0316610416565b61014d61048a565b3480156101d157600080fd5b506101da6104c7565b604080516001600160a01b039092168252519081900360200190f35b600054600160a01b900460ff166102325760008054600160a01b6001600160a01b03199091166001600160a01b0384161760ff60a01b19161790555b50565b6000546001600160a01b03163314610287576040805162461bcd60e51b815260206004820152601060248201526f27b7363c903232b9ba34b730ba34b7b760811b604482015290519081900360640190fd5b60405130903390823180156108fc02916000818181858888f193505050501580156102b6573d6000803e3d6000fd5b5050565b604080516370a0823160e01b8152306004820152905182916000916001600160a01b038416916370a08231916024808301926020929190829003018186803b15801561030557600080fd5b505afa158015610319573d6000803e3d6000fd5b505050506040513d602081101561032f57600080fd5b505190508061033d57600080fd5b600080546040805163a9059cbb60e01b81526001600160a01b0392831660048201526024810185905290519185169263a9059cbb926044808401936020939083900390910190829087803b15801561039457600080fd5b505af11580156103a8573d6000803e3d6000fd5b505050506040513d60208110156103be57600080fd5b50516103c957600080fd5b60408051308152602081018390526001600160a01b0385168183015290517fb4bdccee2343c0b5e592d459c20eb1fa451c96bf88fb685a11aecda6b4ec76b19181900360600190a1505050565b6000546001600160a01b03163314610468576040805162461bcd60e51b815260206004820152601060248201526f27b7363c903232b9ba34b730ba34b7b760811b604482015290519081900360640190fd5b600080546001600160a01b0319166001600160a01b0392909216919091179055565b6000805460405130926001600160a01b0390921691833180156108fc02929091818181858888f193505050501580156102b6573d6000803e3d6000fd5b6000546001600160a01b03168156fea2646970667358221220913e252cf366b03448710a28cdcce0c8617b00ba8c24cf370aced6806ecb15a264736f6c63430007050033";
        public ForwarderDeploymentBase() : base(BYTECODE) { }
        public ForwarderDeploymentBase(string byteCode) : base(byteCode) { }
    }

    public partial class ChangeDestinationFunction : ChangeDestinationFunctionBase { }

    [Function("changeDestination")]
    public class ChangeDestinationFunctionBase : FunctionMessage
    {
        [Parameter("address", "newDestination", 1)]
        public virtual string NewDestination { get; set; }
    }

    public partial class DestinationFunction : DestinationFunctionBase { }

    [Function("destination", "address")]
    public class DestinationFunctionBase : FunctionMessage
    {

    }

    public partial class FlushFunction : FlushFunctionBase { }

    [Function("flush")]
    public class FlushFunctionBase : FunctionMessage
    {

    }

    public partial class FlushTokensFunction : FlushTokensFunctionBase { }

    [Function("flushTokens")]
    public class FlushTokensFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContractAddress", 1)]
        public virtual string TokenContractAddress { get; set; }
    }

    public partial class InitFunction : InitFunctionBase { }

    [Function("init")]
    public class InitFunctionBase : FunctionMessage
    {
        [Parameter("address", "newDestination", 1)]
        public virtual string NewDestination { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw")]
    public class WithdrawFunctionBase : FunctionMessage
    {

    }

    public partial class ForwarderDepositedEventDTO : ForwarderDepositedEventDTOBase { }

    [Event("ForwarderDeposited")]
    public class ForwarderDepositedEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, false)]
        public virtual string From { get; set; }
        [Parameter("uint256", "value", 2, false)]
        public virtual BigInteger Value { get; set; }
        [Parameter("bytes", "data", 3, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class TokensFlushedEventDTO : TokensFlushedEventDTOBase { }

    [Event("TokensFlushed")]
    public class TokensFlushedEventDTOBase : IEventDTO
    {
        [Parameter("address", "forwarderAddress", 1, false)]
        public virtual string ForwarderAddress { get; set; }
        [Parameter("uint256", "value", 2, false)]
        public virtual BigInteger Value { get; set; }
        [Parameter("address", "tokenContractAddress", 3, false)]
        public virtual string TokenContractAddress { get; set; }
    }



    public partial class DestinationOutputDTO : DestinationOutputDTOBase { }

    [FunctionOutput]
    public class DestinationOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
