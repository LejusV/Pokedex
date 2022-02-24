using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Heatmor Specie to store common natural stats of every {'abilities': ['gluttony', 'flash-fire', 'white-smoke'], 'base_experience': 169, 'height': 14, 'id': 631, 'moves': ['fire-punch', 'thunder-punch', 'cut', 'bind', 'tackle', 'body-slam', 'wrap', 'flamethrower', 'low-kick', 'solar-beam', 'fire-spin', 'dig', 'toxic', 'double-team', 'lick', 'fire-blast', 'amnesia', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'superpower', 'recycle', 'knock-off', 'snatch', 'secret-power', 'overheat', 'odor-sleuth', 'rock-tomb', 'tickle', 'aerial-ace', 'fling', 'gastro-acid', 'sucker-punch', 'flare-blitz', 'night-slash', 'focus-blast', 'giga-impact', 'shadow-claw', 'bug-bite', 'hone-claws', 'flame-burst', 'round', 'incinerate', 'inferno', 'belch', 'confide', 'power-up-punch', 'fire-lash'], 'name': 'heatmor', 'stats': {'hp': 85, 'attack': 97, 'defense': 66, 'special-attack': 105, 'special-defense': 66, 'speed': 65}, 'types': ['fire'], 'weight': 580, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'クイタラン', 'ko': '앤티골', 'zh-Hant': '熔蟻獸', 'fr': 'Aflamanoir', 'de': 'Furnifraß', 'es': 'Heatmor', 'it': 'Heatmor', 'en': 'Heatmor', 'ja': 'クイタラン', 'zh-Hans': '熔蚁兽'}, 'genera': {'ja-Hrkt': 'アリクイポケモン', 'ko': '개미핥기포켓몬', 'zh-Hant': '食蟻獸寶可夢', 'fr': 'Pokémon Tamanoir', 'de': 'Ameisenbär', 'es': 'Pokémon Hormiguero', 'it': 'Pokémon Formichiere', 'en': 'Anteater Pokémon', 'ja': 'アリクイポケモン', 'zh-Hans': '食蚁兽宝可梦'}}
	public class SpecieHeatmor : PokemonSpecie
	{
#nullable enable
		private static SpecieHeatmor? _instance = null;
#nullable restore
        public static SpecieHeatmor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeatmor();
                }
                return _instance;
            }
        }

		public SpecieHeatmor() : base(
			"Heatmor",
			85, // HPs
			97, 66, // Attack & Defense
			105, 66, // Special Attack & Defense
			65			
		) {}
	}


	//Heatmor Pokemon Class
	public class Heatmor : Pokemon
	{

		public Heatmor(string nickname, int level)
		: base(
				631,
				SpecieHeatmor.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heatmor(int level)
		: base(
				631,
				SpecieHeatmor.Instance, // Pokemon Specie
				"Heatmor", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heatmor() : base(
			631,
			SpecieHeatmor.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}