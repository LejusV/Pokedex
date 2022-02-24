using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raichu Specie to store common natural stats of every {'abilities': ['static', 'lightning-rod'], 'base_experience': 218, 'height': 8, 'id': 26, 'moves': ['mega-punch', 'pay-day', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'growl', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'swift', 'skull-bash', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'knock-off', 'secret-power', 'signal-beam', 'covet', 'shock-wave', 'natural-gift', 'fling', 'magnet-rise', 'focus-blast', 'giga-impact', 'captivate', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'volt-switch', 'electroweb', 'wild-charge', 'confide'], 'name': 'raichu', 'stats': {'hp': 60, 'attack': 90, 'defense': 55, 'special-attack': 90, 'special-defense': 80, 'speed': 110}, 'types': ['electric'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 75, 'color': 'yellow', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'ライチュウ', 'roomaji': 'Raichu', 'ko': '라이츄', 'zh-Hant': '雷丘', 'fr': 'Raichu', 'de': 'Raichu', 'es': 'Raichu', 'it': 'Raichu', 'en': 'Raichu', 'ja': 'ライチュウ', 'zh-Hans': '雷丘'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpecieRaichu : PokemonSpecie
	{
#nullable enable
		private static SpecieRaichu? _instance = null;
#nullable restore
        public static SpecieRaichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaichu();
                }
                return _instance;
            }
        }

		public SpecieRaichu() : base(
			"Raichu",
			60, // HPs
			90, 55, // Attack & Defense
			90, 80, // Special Attack & Defense
			110			
		) {}
	}


	//Raichu Pokemon Class
	public class Raichu : Pokemon
	{

		public Raichu(string nickname, int level)
		: base(
				26,
				SpecieRaichu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Raichu() : base(
			26,
			SpecieRaichu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}