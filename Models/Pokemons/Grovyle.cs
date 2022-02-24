using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grovyle Specie to store common natural stats of every {'abilities': ['overgrow', 'unburden'], 'base_experience': 142, 'height': 9, 'id': 253, 'moves': ['pound', 'mega-punch', 'thunder-punch', 'swords-dance', 'cut', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'low-kick', 'counter', 'seismic-toss', 'strength', 'absorb', 'mega-drain', 'solar-beam', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'screech', 'double-team', 'swift', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'detect', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'pursuit', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'bullet-seed', 'aerial-ace', 'leaf-blade', 'natural-gift', 'fling', 'worry-seed', 'seed-bomb', 'x-scissor', 'drain-punch', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'low-sweep', 'round', 'quick-guard', 'acrobatics', 'grass-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'grovyle', 'stats': {'hp': 50, 'attack': 65, 'defense': 45, 'special-attack': 85, 'special-defense': 65, 'speed': 95}, 'types': ['grass'], 'weight': 216, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ジュプトル', 'roomaji': 'Juptile', 'ko': '나무돌이', 'zh-Hant': '森林蜥蜴', 'fr': 'Massko', 'de': 'Reptain', 'es': 'Grovyle', 'it': 'Grovyle', 'en': 'Grovyle', 'ja': 'ジュプトル', 'zh-Hans': '森林蜥蜴'}, 'genera': {'ja-Hrkt': 'もりトカゲポケモン', 'ko': '숲도마뱀포켓몬', 'zh-Hant': '林蜥寶可夢', 'fr': 'Pokémon Bois Gecko', 'de': 'Waldgecko', 'es': 'Pokémon Geco Bosque', 'it': 'Pokémon Legnogeco', 'en': 'Wood Gecko Pokémon', 'ja': 'もりトカゲポケモン', 'zh-Hans': '林蜥宝可梦'}}
	public class SpecieGrovyle : PokemonSpecie
	{
#nullable enable
		private static SpecieGrovyle? _instance = null;
#nullable restore
        public static SpecieGrovyle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrovyle();
                }
                return _instance;
            }
        }

		public SpecieGrovyle() : base(
			"Grovyle",
			50, // HPs
			65, 45, // Attack & Defense
			85, 65, // Special Attack & Defense
			95			
		) {}
	}


	//Grovyle Pokemon Class
	public class Grovyle : Pokemon
	{

		public Grovyle(string nickname, int level)
		: base(
				253,
				SpecieGrovyle.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grovyle(int level)
		: base(
				253,
				SpecieGrovyle.Instance, // Pokemon Specie
				"Grovyle", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grovyle() : base(
			253,
			SpecieGrovyle.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}