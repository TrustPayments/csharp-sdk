/**
* Trust Payments SDK
*
* This library allows to interact with the Trust Payments payment service.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TrustPayments.Model;
using TrustPayments.Service;
using TrustPayments.Client;

namespace TrustPayments.Test
{
    /// <summary>
    ///  Class for testing TransactionPaymentPageService
    /// </summary>
    [TestFixture]
    public class TransactionPaymentPageServiceTests
    {
        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
        private TransactionPaymentPageService TransactionPaymentPageService;
        private TransactionCreate TransactionPayload;
        private TransactionService TransactionService;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            if (this.Configuration == null) {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            if (this.TransactionPaymentPageService == null)
            {
                this.TransactionPaymentPageService = new TransactionPaymentPageService(this.Configuration);
            }
            if (this.TransactionService == null)
            {
                this.TransactionService = new TransactionService(this.Configuration);
            }
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        // <summary>
        // Get transaction payload
        // <summary>
        private TransactionCreate GetTransactionPayload()
        {
            if (this.TransactionPayload == null)
            {
                // Line item
                LineItemCreate lineItem1 = new LineItemCreate(
                    name: "Red T-Shirt",
                    uniqueId: "5412",
                    type: LineItemType.PRODUCT,
                    quantity: 1,
                    amountIncludingTax: (decimal)29.95
                )
                {
                    Sku = "red-t-shirt-123"
                };

                // Customer Billing Address
                AddressCreate billingAddress = new AddressCreate
                {
                    City = "Winterthur",
                    Country = "CH",
                    EmailAddress = "test@example.com",
                    FamilyName = "Customer",
                    GivenName = "Good",
                    Postcode = "8400",
                    PostalState = "ZH",
                    OrganizationName = "Test GmbH",
                    MobilePhoneNumber = "+41791234567",
                    Salutation = "Ms"
                };

                this.TransactionPayload = new TransactionCreate(new List<LineItemCreate>() { lineItem1 })
                {
                    Currency = "CHF",
                    AutoConfirmationEnabled = true,
                    BillingAddress = billingAddress,
                    ShippingAddress = billingAddress,
                    Language = "en-US"
                };
            }
            return this.TransactionPayload;
        }

        /// <summary>
        /// Test an instance of TransactionPaymentPageService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TransactionPaymentPageService>(TransactionPaymentPageService, "instance is a TransactionPaymentPageService");
        }

        
        /// <summary>
        /// Test PaymentPageUrl
        /// </summary>
        [Test]
        public void PaymentPageUrlTest()
        {
            Transaction transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
            var response = TransactionPaymentPageService.PaymentPageUrl(this.SpaceId, transaction.Id);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
