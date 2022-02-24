using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Darmanitan-Standard Specie to store common natural stats of every {'abilities': ['sheer-force', 'zen-mode'], 'base_experience': 168, 'height': 13, 'id': 555, 'moves': ['fire-punch', 'headbutt', 'tackle', 'thrash', 'roar', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'psychic', 'rage', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'belly-drum', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'endeavor', 'snatch', 'secret-power', 'overheat', 'rock-tomb', 'bulk-up', 'hammer-arm', 'gyro-ball', 'u-turn', 'payback', 'fling', 'flare-blitz', 'focus-blast', 'giga-impact', 'fire-fang', 'zen-headbutt', 'stone-edge', 'grass-knot', 'smack-down', 'flame-charge', 'round', 'incinerate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'darmanitan-standard', 'stats': {'hp': 105, 'attack': 140, 'defense': 55, 'special-attack': 30, 'special-defense': 55, 'speed': 95}, 'types': ['fire'], 'weight': 929, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒヒダルマ', 'ko': '불비달마', 'zh-Hant': '達摩狒狒', 'fr': 'Darumacho', 'de': 'Flampivian', 'es': 'Darmanitan', 'it': 'Darmanitan', 'en': 'Darmanitan', 'ja': 'ヒヒダルマ', 'zh-Hans': '达摩狒狒'}, 'genera': {'ja-Hrkt': 'えんじょうポケモン', 'ko': '염상포켓몬', 'zh-Hant': '爆燃寶可夢', 'fr': 'Pokémon Enflammé', 'de': 'Lichterloh', 'es': 'Pokémon Candente', 'it': 'Pokémon Altefiamme', 'en': 'Blazing Pokémon', 'ja': 'えんじょうポケモン', 'zh-Hans': '爆燃宝可梦'}}
	public class SpecieDarmanitanStandard : PokemonSpecie
	{
#nullable enable
		private static SpecieDarmanitanStandard? _instance = null;
#nullable restore
        public static SpecieDarmanitanStandard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarmanitanStandard();
                }
                return _instance;
            }
        }

		public SpecieDarmanitanStandard() : base(
			"Darmanitan-Standard",
			105, // HPs
			140, 55, // Attack & Defense
			30, 55, // Special Attack & Defense
			95			
		) {}
	}


	//Darmanitan-Standard Pokemon Class
	public class DarmanitanStandard : Pokemon
	{

		public DarmanitanStandard(string nickname, int level)
		: base(
				555,
				SpecieDarmanitanStandard.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public DarmanitanStandard(int level)
		: base(
				555,
				SpecieDarmanitanStandard.Instance, // Pokemon Specie
				"Darmanitan-Standard", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public DarmanitanStandard() : base(
			555,
			SpecieDarmanitanStandard.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}