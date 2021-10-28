using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ObstacleShould
    {
        GameObject _obstacle;
        ObstacleLife _obstacleLife;

        [SetUp]
        public void Setup()
        {
            _obstacle = new GameObject();
            _obstacleLife = _obstacle.AddComponent<ObstacleLife>();
        }

        [Test]
        public void ReturnLife()
        {
            Assert.AreEqual(3, _obstacleLife.life);
        }

        [Test]
        public void ReceiveDamageAndDecreaseLife()
        {
            //When
            _obstacleLife.ReceiveDamage();
            //Then
            Assert.AreEqual(2, _obstacleLife.life);
        }
        [Test]
        public void ReceiveDamage_DecreaseLifeAndDie()
        {
            //Given
            _obstacleLife.life = 1;
            //When
            _obstacleLife.ReceiveDamage();
            //Then
            Assert.IsNull(_obstacleLife);
        }

    }
}
