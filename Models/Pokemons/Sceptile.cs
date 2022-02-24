using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sceptile Specie to store common natural stats of every {'abilities': ['overgrow', 'unburden'], 'base_experience': 239, 'height': 17, 'id': 254, 'moves': ['pound', 'mega-punch', 'thunder-punch', 'swords-dance', 'cut', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'roar', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'absorb', 'mega-drain', 'solar-beam', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'screech', 'double-team', 'swift', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'detect', 'outrage', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'pursuit', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'bullet-seed', 'aerial-ace', 'dragon-claw', 'frenzy-plant', 'leaf-blade', 'natural-gift', 'fling', 'worry-seed', 'night-slash', 'seed-bomb', 'x-scissor', 'dragon-pulse', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'rock-climb', 'leaf-storm', 'captivate', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'quick-guard', 'acrobatics', 'grass-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'sceptile', 'stats': {'hp': 70, 'attack': 85, 'defense': 65, 'special-attack': 105, 'special-defense': 85, 'speed': 120}, 'types': ['grass'], 'weight': 522, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ジュカイン', 'roomaji': 'Jukain', 'ko': '나무킹', 'zh-Hant': '蜥蜴王', 'fr': 'Jungko', 'de': 'Gewaldro', 'es': 'Sceptile', 'it': 'Sceptile', 'en': 'Sceptile', 'ja': 'ジュカイン', 'zh-Hans': '蜥蜴王'}, 'genera': {'ja-Hrkt': 'みつりんポケモン', 'ko': '밀림포켓몬', 'zh-Hant': '密林寶可夢', 'fr': 'Pokémon Forêt', 'de': 'Dschungel', 'es': 'Pokémon Monte', 'it': 'Pokémon Foresta', 'en': 'Forest Pokémon', 'ja': 'みつりんポケモン', 'zh-Hans': '密林宝可梦'}}
	public class SpecieSceptile : PokemonSpecie
	{
#nullable enable
		private static SpecieSceptile? _instance = null;
#nullable restore
        public static SpecieSceptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSceptile();
                }
                return _instance;
            }
        }

		public SpecieSceptile() : base(
			"Sceptile",
			70, // HPs
			85, 65, // Attack & Defense
			105, 85, // Special Attack & Defense
			120			
		) {}
	}


	//Sceptile Pokemon Class
	public class Sceptile : Pokemon
	{

		public Sceptile(string nickname, int level)
		: base(
				254,
				SpecieSceptile.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sceptile() : base(
			254,
			SpecieSceptile.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}