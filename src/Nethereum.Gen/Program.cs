﻿using System;
using System.Linq;
using Nethereum.ABI.FunctionEncoding;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Nethereum.Gen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //GenerateAugur();
            try
            {
                //if (args[0] == "--?" || args[0] == "--help")
                //{
                //    Console.WriteLine("Just call using as parameters: abi contractName");
                //}
                //else
                //{

                    //string abi = args[0];
                    //string contractName = args[1];

                    var abi =
                        @"[{ ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""name"": ""proposals"", ""outputs"": [{ ""name"": ""recipient"", ""type"": ""address"" }, { ""name"": ""amount"", ""type"": ""uint256"" }, { ""name"": ""description"", ""type"": ""string"" }, { ""name"": ""votingDeadline"", ""type"": ""uint256"" }, { ""name"": ""open"", ""type"": ""bool"" }, { ""name"": ""proposalPassed"", ""type"": ""bool"" }, { ""name"": ""proposalHash"", ""type"": ""bytes32"" }, { ""name"": ""proposalDeposit"", ""type"": ""uint256"" }, { ""name"": ""newCurator"", ""type"": ""bool"" }, { ""name"": ""yea"", ""type"": ""uint256"" }, { ""name"": ""nay"", ""type"": ""uint256"" }, { ""name"": ""creator"", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_spender"", ""type"": ""address"" }, { ""name"": ""_amount"", ""type"": ""uint256"" }], ""name"": ""approve"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""minTokensToCreate"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""rewardAccount"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""daoCreator"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""totalSupply"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""divisor"", ""outputs"": [{ ""name"": ""divisor"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""extraBalance"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }, { ""name"": ""_transactionData"", ""type"": ""bytes"" }], ""name"": ""executeProposal"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_from"", ""type"": ""address"" }, { ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" }], ""name"": ""transferFrom"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [], ""name"": ""unblockMe"", ""outputs"": [{ ""name"": """", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""totalRewardToken"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""actualBalance"", ""outputs"": [{ ""name"": ""_actualBalance"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""closingTime"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""address"" }], ""name"": ""allowedRecipients"", ""outputs"": [{ ""name"": """", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" }], ""name"": ""transferWithoutReward"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [], ""name"": ""refund"", ""outputs"": [], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_recipient"", ""type"": ""address"" }, { ""name"": ""_amount"", ""type"": ""uint256"" }, { ""name"": ""_description"", ""type"": ""string"" }, { ""name"": ""_transactionData"", ""type"": ""bytes"" }, { ""name"": ""_debatingPeriod"", ""type"": ""uint256"" }, { ""name"": ""_newCurator"", ""type"": ""bool"" }], ""name"": ""newProposal"", ""outputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""address"" }], ""name"": ""DAOpaidOut"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""minQuorumDivisor"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_newContract"", ""type"": ""address"" }], ""name"": ""newContract"", ""outputs"": [], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": ""_owner"", ""type"": ""address"" }], ""name"": ""balanceOf"", ""outputs"": [{ ""name"": ""balance"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_recipient"", ""type"": ""address"" }, { ""name"": ""_allowed"", ""type"": ""bool"" }], ""name"": ""changeAllowedRecipients"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [], ""name"": ""halveMinQuorum"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""address"" }], ""name"": ""paidOut"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }, { ""name"": ""_newCurator"", ""type"": ""address"" }], ""name"": ""splitDAO"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""DAOrewardAccount"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""proposalDeposit"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""numberOfProposals"", ""outputs"": [{ ""name"": ""_numberOfProposals"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""lastTimeMinQuorumMet"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_toMembers"", ""type"": ""bool"" }], ""name"": ""retrieveDAOReward"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [], ""name"": ""receiveEther"", ""outputs"": [{ ""name"": """", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" }], ""name"": ""transfer"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""isFueled"", ""outputs"": [{ ""name"": """", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_tokenHolder"", ""type"": ""address"" }], ""name"": ""createTokenProxy"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }], ""name"": ""getNewDAOAddress"", ""outputs"": [{ ""name"": ""_newDAO"", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }, { ""name"": ""_supportsProposal"", ""type"": ""bool"" }], ""name"": ""vote"", ""outputs"": [{ ""name"": ""_voteID"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [], ""name"": ""getMyReward"", ""outputs"": [{ ""name"": ""_success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""address"" }], ""name"": ""rewardToken"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_from"", ""type"": ""address"" }, { ""name"": ""_to"", ""type"": ""address"" }, { ""name"": ""_value"", ""type"": ""uint256"" }], ""name"": ""transferFromWithoutReward"", ""outputs"": [{ ""name"": ""success"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": ""_owner"", ""type"": ""address"" }, { ""name"": ""_spender"", ""type"": ""address"" }], ""name"": ""allowance"", ""outputs"": [{ ""name"": ""remaining"", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": false, ""inputs"": [{ ""name"": ""_proposalDeposit"", ""type"": ""uint256"" }], ""name"": ""changeProposalDeposit"", ""outputs"": [], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": """", ""type"": ""address"" }], ""name"": ""blocked"", ""outputs"": [{ ""name"": """", ""type"": ""uint256"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""curator"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [{ ""name"": ""_proposalID"", ""type"": ""uint256"" }, { ""name"": ""_recipient"", ""type"": ""address"" }, { ""name"": ""_amount"", ""type"": ""uint256"" }, { ""name"": ""_transactionData"", ""type"": ""bytes"" }], ""name"": ""checkProposalCode"", ""outputs"": [{ ""name"": ""_codeChecksOut"", ""type"": ""bool"" }], ""type"": ""function"" }, { ""constant"": true, ""inputs"": [], ""name"": ""privateCreation"", ""outputs"": [{ ""name"": """", ""type"": ""address"" }], ""type"": ""function"" }, { ""inputs"": [{ ""name"": ""_curator"", ""type"": ""address"" }, { ""name"": ""_daoCreator"", ""type"": ""address"" }, { ""name"": ""_proposalDeposit"", ""type"": ""uint256"" }, { ""name"": ""_minTokensToCreate"", ""type"": ""uint256"" }, { ""name"": ""_closingTime"", ""type"": ""uint256"" }, { ""name"": ""_privateCreation"", ""type"": ""address"" }], ""type"": ""constructor"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""_from"", ""type"": ""address"" }, { ""indexed"": true, ""name"": ""_to"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""_amount"", ""type"": ""uint256"" }], ""name"": ""Transfer"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""_owner"", ""type"": ""address"" }, { ""indexed"": true, ""name"": ""_spender"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""_amount"", ""type"": ""uint256"" }], ""name"": ""Approval"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": false, ""name"": ""value"", ""type"": ""uint256"" }], ""name"": ""FuelingToDate"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""to"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""amount"", ""type"": ""uint256"" }], ""name"": ""CreatedToken"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""to"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""value"", ""type"": ""uint256"" }], ""name"": ""Refund"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""proposalID"", ""type"": ""uint256"" }, { ""indexed"": false, ""name"": ""recipient"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""amount"", ""type"": ""uint256"" }, { ""indexed"": false, ""name"": ""newCurator"", ""type"": ""bool"" }, { ""indexed"": false, ""name"": ""description"", ""type"": ""string"" }], ""name"": ""ProposalAdded"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""proposalID"", ""type"": ""uint256"" }, { ""indexed"": false, ""name"": ""position"", ""type"": ""bool"" }, { ""indexed"": true, ""name"": ""voter"", ""type"": ""address"" }], ""name"": ""Voted"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""proposalID"", ""type"": ""uint256"" }, { ""indexed"": false, ""name"": ""result"", ""type"": ""bool"" }, { ""indexed"": false, ""name"": ""quorum"", ""type"": ""uint256"" }], ""name"": ""ProposalTallied"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""_newCurator"", ""type"": ""address"" }], ""name"": ""NewCurator"", ""type"": ""event"" }, { ""anonymous"": false, ""inputs"": [{ ""indexed"": true, ""name"": ""_recipient"", ""type"": ""address"" }, { ""indexed"": false, ""name"": ""_allowed"", ""type"": ""bool"" }], ""name"": ""AllowedRecipientChanged"", ""type"": ""event"" }]";
                    var contractName = "Dao";

                    var generator = new ContractServiceGenerator();
                    var fileName = contractName + "Service.cs";
                    var genContract = generator.ContractGen(abi, contractName, "Nethereum.Dao");
                    var fileOutput = System.IO.File.CreateText(fileName);
                    fileOutput.Write(genContract);
                    fileOutput.Flush();

                    Console.WriteLine("Generated " + fileName);
               // }
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);   
            }
        }

        private static void GenerateAugur()
        {
            var augurJsonLocation = "contractsInfo.json";
            dynamic[] augurContracts = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(augurJsonLocation));
            Console.WriteLine(augurContracts.Length);
            foreach (var contract in augurContracts)
            {
                //var contract = augurContracts[0];
                var functionsABI = new List<dynamic>();
                //Console.WriteLine(contract.functions.Length);
                foreach (dynamic function in contract.functions)
                {
                    try
                    {
                        functionsABI.Add(function.abi);
                    }
                    catch
                    {
                    }
                }
                var abiJ = JsonConvert.SerializeObject(functionsABI.ToArray());
                Console.WriteLine(abiJ);
                var contractName = contract.name.ToString();
                Console.WriteLine(contractName);
                var generator = new ContractServiceGenerator();
                var fileName = generator.MakeFirstCharUpper(contractName) + "Service.cs";
                var genContract = generator.ContractGen(abiJ, contractName, "Augur");
                var fileOutput = System.IO.File.CreateText(fileName);
                fileOutput.Write(genContract);
                fileOutput.Flush();
                fileOutput.Close();
                Console.WriteLine("Generated " + fileName);
            }
        }
    }
  

}



