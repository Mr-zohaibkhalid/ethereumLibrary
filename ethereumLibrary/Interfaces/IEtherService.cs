using ethereumLibrary.Models;
using Transaction = Nethereum.RPC.Eth.DTOs.Transaction;
using TransactionReceipt = Nethereum.RPC.Eth.DTOs.TransactionReceipt;
using Nethereum.Web3.Accounts;
using System.Numerics;
using static ethereumLibrary.Models.SmartContractModel;
using System.Threading.Tasks;
using System.Threading;

namespace ethereumLibrary.Interfaces
{
    public interface IEtherService
    {
        bool CheckAddress(string address);
        Task<decimal> GetTokenBalanceAsync(string address, string tokenContractAddress, string url, int decimalPlaces = 18);
        Task<decimal> GetPlaymatesBalanceAsync(string address, string tokenContractAddress, string url, int decimalPlaces = 18);
        Task<decimal> GetETHBalanceAsync(string address, string url);
        Task<GasTrackModel> GasTrackAsync(string etherscanUrl);
        Task<TransactionReceipt> GetTransactionReceiptByHash(string accountKey, string url, int chainId, string transactionHash);
        Task<Transaction> GetTransactionByHash(string accountKey, string url, int chainId, string transactionHash);

        Task<string> CreateNewAddressAsync(string forwardContractAddress, string forwardFactoryContractAddress, string accountKey, string url, int chainId, long index, string gas = "", string gasPrice = "", int? nonce = null);

        Task<string> FlushTokenAsync(string accountKey, string url, int chainId, string address, string tokenContractAddress, string gas = "", string gasPrice = "", int? nonce = null);

        Task<Transaction> GetTransactionByHash(string url, string transactionHash);
        Task<string> GetDestinationAddressInContract(string accountKey, string url, int chainId, string contractAddress);

        Task<EtherscanTransactionModel> GetErc20TransactionsByAddress(string etherscanUrl, string address);
        Task<TransactionReceipt> GetTransactionReceiptByHash(string url, string transactionHash);
        WalletAccount CreateWallet(string password = "", int index = 0, string words = "");
        Task<string> SendEther(string accountKey, string url, int chainId, string toAddr, BigInteger amount, BigInteger? gastLimit = null, BigInteger? gasPrice = null, bool useLegacy = false);
        Task<string> TransferErc20Token(string accountKey, string url, int chainId, string contractAddress, string toAddr, BigInteger tokenAmount, BigInteger? gastLimit = null, BigInteger? gasPrice = null, bool useLegacy = false);
        Account GetAccount(string password, int index, string words);

        Account GetAccount(string accountKey, int chainId);
        string GetMnemonics();
        Task<decimal> GetBalanceOf(string address, int decimalPlaces = 18);
        Task<string> ApproveErc20Token(string accountKey, string url, int chainId, string contractAddress, string toAddr, BigInteger tokenAmount, BigInteger? gastLimit = null, BigInteger? gasPrice = null, bool useLegacy = false);
        bool IsValidMessageAddress(string message, string signature, string address);

        //Communication Contracts Interfaces
        TransactionReceipt UserRegister(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, UserRegisterModel userModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt CreateChatContract(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, ChatContractRegisterModel chatContractModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt SendMessageContract(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendMessageRegisterModel sendMessageModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        string GetChatContract(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, GetChatContractModel getChatContractModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        string GetAddressByEmail(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, GetAddressByEmailModel getAddressByEmailModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt BlockUser(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, BlockUserModelRequest blockUserModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt UnblockUser(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, UnblockUserModelRequest unblockUserModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt CreateGroup(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, CreateGroupModelRequest createGroupModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        string GetGroupAddress(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, GetGroupAddressModelRequest getGroupAddressModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt AddMember(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, AddMemberModelRequest addMemberModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt SendGroupMessage(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendGroupMessageModelRequest sendMessageModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt LeaveGroup(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, LeaveGroupModelRequest leaveGroupModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt RemoveMember(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, RemoveMemberModelRequest removeMemberModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt DirectCall(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, DirectCallModelRequest directCallModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt GroupCall(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, GroupCallModelRequest groupCallModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt StartMeeting(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, StartMeetingModelRequest startMeetingModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt SendChatsReward(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendChatRewardModelRequest sendChatRewardModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt SendCallsReward(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendCallRewardModelRequest sendCallRewardModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt SendMeetingsReward(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendMeetingRewardModelRequest sendMeetingRewardModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt WeeklyReward(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, SendWeeklyRewardModelRequest sendWeeklyRewardModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt UpdateRegistration(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, UpdateRegistrationModelRequest updateRegistrationModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        string GetEmailByAddress(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, GetEmailByAddresslModel getEmailByAddressModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
        TransactionReceipt UpdatePassword(string nodeUrl, int chainId, string accountPrivateKey, string contractAddress, UpdatePasswordModel updatePasswordModelRequest, bool UseLegacyAsDefault = false, CancellationTokenSource cancellationToken = null);
    }
}