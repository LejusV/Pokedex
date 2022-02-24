using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Breloom Specie to store common natural stats of every {'abilities': ['effect-spore', 'poison-heal', 'technician'], 'base_experience': 161, 'height': 12, 'id': 286, 'moves': ['mega-punch', 'thunder-punch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'stun-spore', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'rock-slide', 'substitute', 'mind-reader', 'snore', 'protect', 'mach-punch', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'superpower', 'brick-break', 'snatch', 'secret-power', 'rock-tomb', 'sky-uppercut', 'bullet-seed', 'bulk-up', 'natural-gift', 'feint', 'fling', 'worry-seed', 'force-palm', 'seed-bomb', 'drain-punch', 'vacuum-wave', 'focus-blast', 'energy-ball', 'giga-impact', 'stone-edge', 'captivate', 'grass-knot', 'venoshock', 'low-sweep', 'round', 'retaliate', 'work-up', 'confide', 'power-up-punch'], 'name': 'breloom', 'stats': {'hp': 60, 'attack': 130, 'defense': 80, 'special-attack': 60, 'special-defense': 60, 'speed': 70}, 'types': ['grass', 'fighting'], 'weight': 392, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'green', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'キノガッサ', 'roomaji': 'Kinogassa', 'ko': '버섯모', 'zh-Hant': '斗笠菇', 'fr': 'Chapignon', 'de': 'Kapilz', 'es': 'Breloom', 'it': 'Breloom', 'en': 'Breloom', 'ja': 'キノガッサ', 'zh-Hans': '斗笠菇'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieBreloom : PokemonSpecie
	{
#nullable enable
		private static SpecieBreloom? _instance = null;
#nullable restore
        public static SpecieBreloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBreloom();
                }
                return _instance;
            }
        }

		public SpecieBreloom() : base(
			"Breloom",
			60, // HPs
			130, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			70			
		) {}
	}


	//Breloom Pokemon Class
	public class Breloom : Pokemon
	{

		public Breloom(string nickname, int level)
		: base(
				286,
				SpecieBreloom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Breloom(int level)
		: base(
				286,
				SpecieBreloom.Instance, // Pokemon Specie
				"Breloom", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Breloom() : base(
			286,
			SpecieBreloom.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
	}
}