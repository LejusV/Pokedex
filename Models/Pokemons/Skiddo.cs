using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skiddo Specie to store common natural stats of every {'abilities': ['sap-sipper', 'grass-pelt'], 'base_experience': 70, 'height': 9, 'id': 672, 'moves': ['vine-whip', 'tackle', 'take-down', 'double-edge', 'tail-whip', 'roar', 'surf', 'strength', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'dig', 'toxic', 'double-team', 'defense-curl', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'giga-drain', 'rollout', 'swagger', 'milk-drink', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'brick-break', 'secret-power', 'bulk-up', 'leaf-blade', 'payback', 'worry-seed', 'seed-bomb', 'energy-ball', 'zen-headbutt', 'grass-knot', 'round', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'horn-leech', 'grassy-terrain', 'confide'], 'name': 'skiddo', 'stats': {'hp': 66, 'attack': 65, 'defense': 48, 'special-attack': 62, 'special-defense': 57, 'speed': 52}, 'types': ['grass'], 'weight': 310, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'メェークル', 'ko': '메이클', 'zh-Hant': '坐騎小羊', 'fr': 'Cabriolaine', 'de': 'Mähikel', 'es': 'Skiddo', 'it': 'Skiddo', 'en': 'Skiddo', 'ja': 'メェークル', 'zh-Hans': '坐骑小羊'}, 'genera': {'ja-Hrkt': 'ライドポケモン', 'ko': '라이드포켓몬', 'zh-Hant': '坐騎寶可夢', 'fr': 'Pokémon Monture', 'de': 'Ritt', 'es': 'Pokémon Montura', 'it': 'Pokémon Cavalcatura', 'en': 'Mount Pokémon', 'ja': 'ライドポケモン', 'zh-Hans': '坐骑宝可梦'}}
	public class SpecieSkiddo : PokemonSpecie
	{
#nullable enable
		private static SpecieSkiddo? _instance = null;
#nullable restore
        public static SpecieSkiddo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkiddo();
                }
                return _instance;
            }
        }

		public SpecieSkiddo() : base(
			"Skiddo",
			66, // HPs
			65, 48, // Attack & Defense
			62, 57, // Special Attack & Defense
			52			
		) {}
	}


	//Skiddo Pokemon Class
	public class Skiddo : Pokemon
	{

		public Skiddo(string nickname, int level)
		: base(
				672,
				SpecieSkiddo.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skiddo() : base(
			672,
			SpecieSkiddo.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}