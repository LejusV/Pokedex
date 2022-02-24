using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rapidash Specie to store common natural stats of every {'abilities': ['run-away', 'flash-fire', 'flame-body'], 'base_experience': 175, 'height': 17, 'id': 78, 'moves': ['stomp', 'headbutt', 'fury-attack', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'growl', 'ember', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'fire-spin', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'flame-wheel', 'snore', 'curse', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'iron-tail', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'overheat', 'bounce', 'natural-gift', 'flare-blitz', 'poison-jab', 'giga-impact', 'captivate', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'inferno', 'wild-charge', 'drill-run', 'confide', 'smart-strike'], 'name': 'rapidash', 'stats': {'hp': 65, 'attack': 100, 'defense': 70, 'special-attack': 80, 'special-defense': 80, 'speed': 105}, 'types': ['fire'], 'weight': 950, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ギャロップ', 'roomaji': 'Gallop', 'ko': '날쌩마', 'zh-Hant': '烈焰馬', 'fr': 'Galopa', 'de': 'Gallopa', 'es': 'Rapidash', 'it': 'Rapidash', 'en': 'Rapidash', 'ja': 'ギャロップ', 'zh-Hans': '烈焰马'}, 'genera': {'ja-Hrkt': 'ひのうまポケモン', 'ko': '불의말포켓몬', 'zh-Hant': '火馬寶可夢', 'fr': 'Pokémon Cheval Feu', 'de': 'Feuerpferd', 'es': 'Pokémon Caballo F.', 'it': 'Pokémon Cavalfuoco', 'en': 'Fire Horse Pokémon', 'ja': 'ひのうまポケモン', 'zh-Hans': '火马宝可梦'}}
	public class SpecieRapidash : PokemonSpecie
	{
#nullable enable
		private static SpecieRapidash? _instance = null;
#nullable restore
        public static SpecieRapidash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRapidash();
                }
                return _instance;
            }
        }

		public SpecieRapidash() : base(
			"Rapidash",
			65, // HPs
			100, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			105			
		) {}
	}


	//Rapidash Pokemon Class
	public class Rapidash : Pokemon
	{

		public Rapidash(string nickname, int level)
		: base(
				78,
				SpecieRapidash.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rapidash() : base(
			78,
			SpecieRapidash.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}