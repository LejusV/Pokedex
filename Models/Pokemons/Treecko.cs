using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Treecko Specie to store common natural stats of every {'abilities': ['overgrow', 'unburden'], 'base_experience': 62, 'height': 5, 'id': 252, 'moves': ['pound', 'mega-punch', 'thunder-punch', 'razor-wind', 'swords-dance', 'cut', 'slam', 'double-kick', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'low-kick', 'counter', 'seismic-toss', 'strength', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'screech', 'double-team', 'swift', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'detect', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'dragon-breath', 'pursuit', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'endeavor', 'secret-power', 'mud-sport', 'crush-claw', 'rock-tomb', 'grass-whistle', 'bullet-seed', 'aerial-ace', 'magical-leaf', 'natural-gift', 'fling', 'worry-seed', 'seed-bomb', 'drain-punch', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'round', 'quick-guard', 'acrobatics', 'grass-pledge', 'work-up', 'grassy-terrain', 'confide', 'power-up-punch'], 'name': 'treecko', 'stats': {'hp': 40, 'attack': 45, 'defense': 35, 'special-attack': 65, 'special-defense': 55, 'speed': 70}, 'types': ['grass'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'キモリ', 'roomaji': 'Kimori', 'ko': '나무지기', 'zh-Hant': '木守宮', 'fr': 'Arcko', 'de': 'Geckarbor', 'es': 'Treecko', 'it': 'Treecko', 'en': 'Treecko', 'ja': 'キモリ', 'zh-Hans': '木守宫'}, 'genera': {'ja-Hrkt': 'もりトカゲポケモン', 'ko': '숲도마뱀포켓몬', 'zh-Hant': '林蜥寶可夢', 'fr': 'Pokémon Bois Gecko', 'de': 'Waldgecko', 'es': 'Pokémon Geco Bosque', 'it': 'Pokémon Legnogeco', 'en': 'Wood Gecko Pokémon', 'ja': 'もりトカゲポケモン', 'zh-Hans': '林蜥宝可梦'}}
	public class SpecieTreecko : PokemonSpecie
	{
#nullable enable
		private static SpecieTreecko? _instance = null;
#nullable restore
        public static SpecieTreecko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTreecko();
                }
                return _instance;
            }
        }

		public SpecieTreecko() : base(
			"Treecko",
			40, // HPs
			45, 35, // Attack & Defense
			65, 55, // Special Attack & Defense
			70			
		) {}
	}


	//Treecko Pokemon Class
	public class Treecko : Pokemon
	{

		public Treecko(string nickname, int level)
		: base(
				252,
				SpecieTreecko.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Treecko() : base(
			252,
			SpecieTreecko.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}