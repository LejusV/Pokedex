using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slakoth Specie to store common natural stats of every {'abilities': ['truant'], 'base_experience': 56, 'height': 8, 'id': 287, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'flamethrower', 'ice-beam', 'blizzard', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'toxic', 'mimic', 'double-team', 'fire-blast', 'amnesia', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'brick-break', 'yawn', 'secret-power', 'slack-off', 'crush-claw', 'rock-tomb', 'tickle', 'aerial-ace', 'bulk-up', 'covet', 'shock-wave', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'sucker-punch', 'night-slash', 'shadow-claw', 'gunk-shot', 'captivate', 'hone-claws', 'after-you', 'round', 'chip-away', 'incinerate', 'retaliate', 'work-up', 'play-rough', 'confide', 'power-up-punch'], 'name': 'slakoth', 'stats': {'hp': 60, 'attack': 60, 'defense': 60, 'special-attack': 35, 'special-defense': 35, 'speed': 30}, 'types': ['normal'], 'weight': 240, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ナマケロ', 'roomaji': 'Namakero', 'ko': '게을로', 'zh-Hant': '懶人獺', 'fr': 'Parecool', 'de': 'Bummelz', 'es': 'Slakoth', 'it': 'Slakoth', 'en': 'Slakoth', 'ja': 'ナマケロ', 'zh-Hans': '懒人獭'}, 'genera': {'ja-Hrkt': 'なまけものポケモン', 'ko': '게으름뱅이포켓몬', 'zh-Hant': '懶人寶可夢', 'fr': 'Pokémon Flâneur', 'de': 'Faulpelz', 'es': 'Pokémon Gandul', 'it': 'Pokémon Ozioso', 'en': 'Slacker Pokémon', 'ja': 'なまけものポケモン', 'zh-Hans': '懒人宝可梦'}}
	public class SpecieSlakoth : PokemonSpecie
	{
#nullable enable
		private static SpecieSlakoth? _instance = null;
#nullable restore
        public static SpecieSlakoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlakoth();
                }
                return _instance;
            }
        }

		public SpecieSlakoth() : base(
			"Slakoth",
			60, // HPs
			60, 60, // Attack & Defense
			35, 35, // Special Attack & Defense
			30			
		) {}
	}


	//Slakoth Pokemon Class
	public class Slakoth : Pokemon
	{

		public Slakoth(string nickname, int level)
		: base(
				287,
				SpecieSlakoth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slakoth(int level)
		: base(
				287,
				SpecieSlakoth.Instance, // Pokemon Specie
				"Slakoth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slakoth() : base(
			287,
			SpecieSlakoth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}