using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Delcatty Specie to store common natural stats of every {'abilities': ['cute-charm', 'normalize', 'wonder-skin'], 'base_experience': 140, 'height': 11, 'id': 301, 'moves': ['double-slap', 'headbutt', 'body-slam', 'double-edge', 'growl', 'sing', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'uproar', 'facade', 'helping-hand', 'secret-power', 'hyper-voice', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'payback', 'last-resort', 'sucker-punch', 'giga-impact', 'zen-headbutt', 'captivate', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'retaliate', 'work-up', 'wild-charge', 'confide'], 'name': 'delcatty', 'stats': {'hp': 70, 'attack': 65, 'defense': 65, 'special-attack': 55, 'special-defense': 55, 'speed': 90}, 'types': ['normal'], 'weight': 326, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 6, 'capture_rate': 60, 'color': 'purple', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'エネコロロ', 'roomaji': 'Enekororo', 'ko': '델케티', 'zh-Hant': '優雅貓', 'fr': 'Delcatty', 'de': 'Enekoro', 'es': 'Delcatty', 'it': 'Delcatty', 'en': 'Delcatty', 'ja': 'エネコロロ', 'zh-Hans': '优雅猫'}, 'genera': {'ja-Hrkt': 'おすましポケモン', 'ko': '새침떼기포켓몬', 'zh-Hant': '清高寶可夢', 'fr': 'Pokémon Guindé', 'de': 'Eingebildet', 'es': 'Pokémon Cursi', 'it': 'Pokémon Finezza', 'en': 'Prim Pokémon', 'ja': 'おすましポケモン', 'zh-Hans': '清高宝可梦'}}
	public class SpecieDelcatty : PokemonSpecie
	{
#nullable enable
		private static SpecieDelcatty? _instance = null;
#nullable restore
        public static SpecieDelcatty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelcatty();
                }
                return _instance;
            }
        }

		public SpecieDelcatty() : base(
			"Delcatty",
			70, // HPs
			65, 65, // Attack & Defense
			55, 55, // Special Attack & Defense
			90			
		) {}
	}


	//Delcatty Pokemon Class
	public class Delcatty : Pokemon
	{

		public Delcatty(string nickname, int level)
		: base(
				301,
				SpecieDelcatty.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Delcatty() : base(
			301,
			SpecieDelcatty.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}