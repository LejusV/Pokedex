using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pikachu Specie to store common natural stats of every {'abilities': ['static', 'lightning-rod'], 'base_experience': 112, 'height': 4, 'id': 25, 'moves': ['mega-punch', 'pay-day', 'thunder-punch', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'growl', 'surf', 'submission', 'counter', 'seismic-toss', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'swift', 'skull-bash', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'knock-off', 'secret-power', 'signal-beam', 'covet', 'shock-wave', 'natural-gift', 'feint', 'fling', 'magnet-rise', 'discharge', 'captivate', 'grass-knot', 'charge-beam', 'electro-ball', 'round', 'echoed-voice', 'volt-switch', 'electroweb', 'wild-charge', 'play-nice', 'confide', 'nuzzle'], 'name': 'pikachu', 'stats': {'hp': 35, 'attack': 55, 'defense': 40, 'special-attack': 50, 'special-defense': 50, 'speed': 90}, 'types': ['electric'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'ピカチュウ', 'roomaji': 'Pikachu', 'ko': '피카츄', 'zh-Hant': '皮卡丘', 'fr': 'Pikachu', 'de': 'Pikachu', 'es': 'Pikachu', 'it': 'Pikachu', 'en': 'Pikachu', 'ja': 'ピカチュウ', 'zh-Hans': '皮卡丘'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpeciePikachu : PokemonSpecie
	{
#nullable enable
		private static SpeciePikachu? _instance = null;
#nullable restore
        public static SpeciePikachu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePikachu();
                }
                return _instance;
            }
        }

		public SpeciePikachu() : base(
			"Pikachu",
			35, // HPs
			55, 40, // Attack & Defense
			50, 50, // Special Attack & Defense
			90			
		) {}
	}


	//Pikachu Pokemon Class
	public class Pikachu : Pokemon
	{

		public Pikachu(string nickname, int level) : base(
			25,
			SpeciePikachu.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Pikachu() : base(
			25,
			SpeciePikachu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}