using NBitcoin;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Collections.Generic;
using System.Numerics;

namespace ethereumLibrary.Models
{
    public class SmartContractModel
    {
        //User Registeration Model Class
        public partial class UserRegisterModel : UserRegisterBaseRequest { }
        [Function("Registration")]
        public class UserRegisterBaseRequest : FunctionMessage
        {
            [Parameter("address", "userAddress", 1)]
            public virtual string userAddress { get; set; } = string.Empty;

            [Parameter("string", "Email", 2)]
            public virtual string Email { get; set; } = string.Empty;
            [Parameter("string", "_password", 3)]
            public virtual string _password { get; set; } = string.Empty;
        }

        //Create Chat Contract Model Class
        public partial class ChatContractRegisterModel : ChatContractRegisterBaseRequest { }
        [Function("CreateChatContract")]
        public class ChatContractRegisterBaseRequest : FunctionMessage
        {
            [Parameter("string", "Email1", 1)]
            public virtual string Email1 { get; set; } = string.Empty;
            [Parameter("string", "Email2", 2)]
            public virtual string Email2 { get; set; } = string.Empty;
        }

        //Send Message Contract Model Class
        public partial class SendMessageRegisterModel : SendMessageBaseRequest { }
        [Function("addChatMessage")]
        public class SendMessageBaseRequest : FunctionMessage
        {
            [Parameter("address", "_user1", 1)]
            public virtual string _user1 { get; set; } = string.Empty;
            [Parameter("address", "_user2", 2)]
            public virtual string _user2 { get; set; } = string.Empty;
            [Parameter("string", "userMessage", 3)]
            public virtual string userMessage { get; set; } = string.Empty;
            [Parameter("bool", "ismedia", 4)]
            public virtual bool ismedia { get; set; } = false;
        }

        //Get Chat Contract Address Model Class
        public partial class GetChatContractModel : GetChatContractBaseRequest { }
        [Function("getChatContract")]
        public class GetChatContractBaseRequest : FunctionMessage
        {
            [Parameter("address", "user1", 1)]
            public virtual string user1 { get; set; } = string.Empty;
            [Parameter("address", "user2", 2)]
            public virtual string user2 { get; set; } = string.Empty;
        }

        //Get Chat Address By Email Model Class
        public partial class GetAddressByEmailModel : GetAddressByEmailBaseRequest { }
        [Function("getAddressByEmail")]
        public class GetAddressByEmailBaseRequest : FunctionMessage
        {
            [Parameter("string", "EmailAddress", 1)]
            public virtual string EmailAddress { get; set; } = string.Empty;
        }
        public partial class GetEmailByAddresslModel : GetEmailByAddressBaseRequest { }
        [Function("getEmailByAddress")]
        public class GetEmailByAddressBaseRequest : FunctionMessage
        {
            [Parameter("string", "userAddress", 1)]
            public virtual string userAddress { get; set; } = string.Empty;
        }

        //Block User Contract Model Class
        public partial class BlockUserModelRequest : BlockUserBaseRequest { }
        [Function("blockUser")]
        public class BlockUserBaseRequest : FunctionMessage
        {
            [Parameter("address", "userToBeBlocked", 1)]
            public virtual string userToBeBlocked { get; set; } = string.Empty;
            [Parameter("address", "blockedByUser", 2)]
            public virtual string blockedByUser { get; set; } = string.Empty;
        }

        //Unblock User Contract Model Class
        public partial class UnblockUserModelRequest : UnblockUserBaseRequest { }
        [Function("unblockUser")]
        public class UnblockUserBaseRequest : FunctionMessage
        {
            [Parameter("address", "userToBeUnBlocked", 1)]
            public virtual string userToBeBlocked { get; set; } = string.Empty;
        }

        //Create Group Contact Model Class
        public partial class CreateGroupModelRequest : CreateGroupBaseRequest { }
        [Function("createGroupChatContract")]
        public class CreateGroupBaseRequest : FunctionMessage
        {
            [Parameter("string[]", "participantEmails", 1)]
            public virtual string[] participantEmails { get; set; }
            [Parameter("string", "groupID", 2)]
            public virtual string groupID { get; set; } = string.Empty;
            [Parameter("string", "createrofGroupEmail", 3)]
            public virtual string createrofGroupEmail { get; set; } = string.Empty;
            [Parameter("string", "groupName", 4)]
            public virtual string groupName { get; set; } = string.Empty;
            [Parameter("string", "groupPicture", 5)]
            public virtual string groupPicture { get; set; } = string.Empty;
            [Parameter("string", "groupDescription", 6)]
            public virtual string groupDescription { get; set; } = string.Empty;
        }

        //Get Group Contract Address Model Class
        public partial class GetGroupAddressModelRequest : GetGroupAddressBaseRequest { }
        [Function("getGroupChatContract")]
        public class GetGroupAddressBaseRequest : FunctionMessage
        {
            [Parameter("string", "groupId", 1)]
            public virtual string groupId { get; set; } = string.Empty;
        }

        //Add Member Contract Model Class
        public partial class AddMemberModelRequest : AddMemberBaseRequest { }
        [Function("addMember")]
        public class AddMemberBaseRequest : FunctionMessage
        {
            [Parameter("string", "Email", 1)]
            public virtual string Email { get; set; } = string.Empty;
            [Parameter("string", "groupId", 2)]
            public virtual string groupId { get; set; } = string.Empty;
        }

        //Send Group Message Contract Model Class
        public partial class SendGroupMessageModelRequest : SendGroupMessageBaseRequest { }
        [Function("addChatMessage")]
        public class SendGroupMessageBaseRequest : FunctionMessage
        {
            [Parameter("address", "Sender", 1)]
            public virtual string Sender { get; set; } = string.Empty;
            [Parameter("string", "groupId", 2)]
            public virtual string groupId { get; set; } = string.Empty;
            [Parameter("string", "message", 3)]
            public virtual string message { get; set; } = string.Empty;
            [Parameter("bool", "ismedia", 4)]
            public virtual bool ismedia { get; set; } = false;
        }
        //Leave Group Contract Model Class
        public partial class LeaveGroupModelRequest : LeaveGroupBaseRequest { }
        [Function("LeaveGroup")]
        public class LeaveGroupBaseRequest : FunctionMessage
        {
            [Parameter("address", "groupId", 1)]
            public virtual string groupId { get; set; } = string.Empty;
            [Parameter("string", "member", 2)]
            public virtual string member { get; set; } = string.Empty;
        }
        //Remove Member Contract Model Class
        public partial class RemoveMemberModelRequest : RemoveMemberBaseRequest { }
        [Function("removeMember")]
        public class RemoveMemberBaseRequest : FunctionMessage
        {
            [Parameter("address", "member", 1)]
            public virtual string member { get; set; } = string.Empty;
            [Parameter("string", "groupId", 2)]
            public virtual string groupId { get; set; } = string.Empty;
        }
        //One-To-One Call Contract Model Class
        public partial class DirectCallModelRequest : DirectCallBaseRequest { }
        [Function("callAFriend")]
        public class DirectCallBaseRequest : FunctionMessage
        {
            [Parameter("address", "caller", 1)]
            public virtual string caller { get; set; } = string.Empty;
            [Parameter("address", "receiver", 2)]
            public virtual string receiver { get; set; } = string.Empty;
            [Parameter("uint256", "startTime", 3)]
            public virtual long startTime { get; set; }
            [Parameter("uint256", "endTime", 4)]
            public virtual long endTime { get; set; }
        }
        //Group Call Contract Model Class
        public partial class GroupCallModelRequest : GroupCallBaseRequest { }
        [Function("callAGroup")]
        public class GroupCallBaseRequest : FunctionMessage
        {
            [Parameter("address", "caller", 1)]
            public virtual string caller { get; set; } = string.Empty;
            [Parameter("string", "groupId", 2)]
            public virtual string groupId { get; set; } = string.Empty;
            [Parameter("address[]", "participants", 3)]
            public virtual List<string> participants { get; set; }
            [Parameter("uint256", "startTime", 4)]
            public virtual long startTime { get; set; }
            [Parameter("uint256", "endTime", 5)]
            public virtual long endTime { get; set; }
        }
        //Start Meeting Contract Model Class
        public partial class StartMeetingModelRequest : StartMeetingBaseRequest { }
        [Function("startMeeting")]
        public class StartMeetingBaseRequest : FunctionMessage
        {
            [Parameter("uint256", "meetingId", 1)]
            public virtual BigInteger meetingId { get; set; }
            [Parameter("address", "caller", 2)]
            public virtual string caller { get; set; } = string.Empty;
            [Parameter("address[]", "participants", 3)]
            public virtual List<string> participants { get; set; }
        }
        //Send Chat Reward Contract
        public partial class SendChatRewardModelRequest : SendChatRewardBaseRequest { }
        [Function("sendChatRewards")]
        public class SendChatRewardBaseRequest : FunctionMessage
        {
            [Parameter("address[]", "recipients", 1)]
            public virtual List<string> recipients { get; set; } 
            [Parameter("uint256[]", "amounts", 2)]
            public virtual BigInteger[] amounts { get; set; }
        }
        //Send Call Rewards Contracts
        public partial class SendCallRewardModelRequest : SendCallRewardBaseRequest { }
        [Function("sendCallRewards")]
        public class SendCallRewardBaseRequest : FunctionMessage
        {
            [Parameter("address[]", "recipients", 1)]
            public virtual List<string> recipients { get; set; }
            [Parameter("uint256[]", "amounts", 2)]
            public virtual BigInteger[] amounts { get; set; }
        }
        //Send Meeting Rewards Contracts
        public partial class SendMeetingRewardModelRequest : SendMeetingRewardBaseRequest { }
        [Function("sendMeetingRewards")]
        public class SendMeetingRewardBaseRequest : FunctionMessage
        {
            [Parameter("address[]", "recipients", 1)]
            public virtual List<string> recipients { get; set; }
            [Parameter("uint256[]", "amounts", 2)]
            public virtual BigInteger[] amounts { get; set; }
        }
        //Send Daily Rewards Contracts
        public partial class SendWeeklyRewardModelRequest : SendWeeklyRewardBaseRequest { }
        [Function("sendDailyRewards")]
        public class SendWeeklyRewardBaseRequest : FunctionMessage
        {
            [Parameter("address[]", "recipients", 1)]
            public virtual List<string> recipients { get; set; }
            [Parameter("uint256[]", "amounts", 2)]
            public virtual BigInteger[] amounts { get; set; }
        }
        public class BalanceOfFunctionModelRequest : BalanceOfFunctionBase { }

        [Function("balanceOf", "uint256")]
        public class BalanceOfFunctionBase : FunctionMessage
        {
            [Parameter("address", "account", 1)]
            public virtual string account { get; set; }
        } 
        public class UpdateRegistrationModelRequest : UpdateRegistrationBase { }

        [Function("UpdateRegistration")]
        public class UpdateRegistrationBase : FunctionMessage
        {
            [Parameter("address", "_previousAddress", 1)]
            public virtual string _previousAddress { get; set; } 
            [Parameter("address", "_newAddress", 2)]
            public virtual string _newAddress { get; set; } 
            [Parameter("address", "_userEmail", 3)]
            public virtual string _userEmail { get; set; }
        }
        public partial class UpdatePasswordModel : UpdatePasswordBaseRequest { }
        [Function("updateRegistrationPassword")]
        public class UpdatePasswordBaseRequest : FunctionMessage
        {
            [Nethereum.ABI.FunctionEncoding.Attributes.Parameter("string", "_email")]
            public virtual string _email { get; set; } = string.Empty;
            [Nethereum.ABI.FunctionEncoding.Attributes.Parameter("string", "_prePassword")]
            public string _prePassword { get; set; } = string.Empty;
            [Nethereum.ABI.FunctionEncoding.Attributes.Parameter("string", "_newPassword")]
            public string _newPassword { get; set; } = string.Empty;
        }
        public class WalletAccount
        {
            public string Mnemonics { get; set; }
            public string PrivateKey { get; set; }
            public string PublicKey { get; set; }
            public string Address { get; set; }
        }
    }
}