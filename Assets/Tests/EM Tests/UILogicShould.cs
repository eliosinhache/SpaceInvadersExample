using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using TMPro;

namespace Tests
{
    public class UILogicShould
    {
        GameObject _player;
        PlayerLife _lifePlayerScript;
        PlayerScore _playerScore;
        TextMeshProUGUI _text;
        Slider _lifeBar;

        [SetUp]
        public void Setup()
        {
            _player = new GameObject();
            _lifePlayerScript = _player.AddComponent<PlayerLife>();
            _playerScore = _player.AddComponent<PlayerScore>();
            _text = _player.AddComponent<TextMeshProUGUI>();
            _lifeBar = _player.AddComponent<Slider>();
            _playerScore.score = 0;
            _lifePlayerScript.healt = 100;
        }

        [Test]
        public void ReturnHealtLevel()
        {
            //Then
            Assert.AreEqual(100,_lifePlayerScript.healt);
        }

        [Test]
        public void ReceiveDamage()
        {
            //When
          _lifePlayerScript.ReceiveDamageAndDecreaseHealt(10);
            //Then
            Assert.AreEqual(90,_lifePlayerScript.healt);
        }

        [Test]
        public void ReceiveHeal()
        {
            //When
            _lifePlayerScript.healt = 90;
            _lifePlayerScript.ReceiveHealAndIncreaseHealt(10);
            //Then
            Assert.AreEqual(100,_lifePlayerScript.healt);
        }

        [Test]
        public void ReturnCurrentScore()
        {
            //Then
            Assert.AreEqual(0, _playerScore.score);
        }

        [Test]
        public void ReceivePointsAndIncreaseScore()
        {
            //When
            _playerScore.IncreaseScore(20);
            //Then
            Assert.AreEqual(20, _playerScore.score);
        }
    }
}
