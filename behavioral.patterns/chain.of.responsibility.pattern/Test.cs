using System;
using System.Collections.Generic;
using Xunit;

namespace chain.of.responsibility.pattern
{
    public class Test
    {
        [Fact]
        public void ApprovalTest()
        {
            // Arrange
            
            // Act
            var result = new Approval().ApproveExpense(500m);

            // Assert
            Assert.Equal(result, ApprovalResponse.Approved);
        }
        
    }
}