using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lucario Specie to store common natural stats of every {'abilities': ['steadfast', 'inner-focus', 'justified'], 'base_experience': 184, 'height': 12, 'id': 448, 'moves': ['ice-punch', 'thunder-punch', 'swords-dance', 'headbutt', 'roar', 'hyper-beam', 'low-kick', 'counter', 'strength', 'earthquake', 'dig', 'toxic', 'psychic', 'quick-attack', 'double-team', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'foresight', 'detect', 'bone-rush', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'extreme-speed', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'brick-break', 'secret-power', 'rock-tomb', 'metal-sound', 'iron-defense', 'bulk-up', 'calm-mind', 'water-pulse', 'natural-gift', 'feint', 'close-combat', 'payback', 'fling', 'me-first', 'magnet-rise', 'force-palm', 'aura-sphere', 'poison-jab', 'dark-pulse', 'dragon-pulse', 'drain-punch', 'vacuum-wave', 'focus-blast', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'flash-cannon', 'rock-climb', 'stone-edge', 'captivate', 'hone-claws', 'low-sweep', 'round', 'quick-guard', 'heal-pulse', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch', 'laser-focus'], 'name': 'lucario', 'stats': {'hp': 70, 'attack': 110, 'defense': 70, 'special-attack': 115, 'special-defense': 70, 'speed': 90}, 'types': ['fighting', 'steel'], 'weight': 540, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ルカリオ', 'roomaji': 'Lucario', 'ko': '루카리오', 'zh-Hant': '路卡利歐', 'fr': 'Lucario', 'de': 'Lucario', 'es': 'Lucario', 'it': 'Lucario', 'en': 'Lucario', 'ja': 'ルカリオ', 'zh-Hans': '路卡利欧'}, 'genera': {'ja-Hrkt': 'はどうポケモン', 'ko': '파동포켓몬', 'zh-Hant': '波導寶可夢', 'fr': 'Pokémon Aura', 'de': 'Aura', 'es': 'Pokémon Aura', 'it': 'Pokémon Aura', 'en': 'Aura Pokémon', 'ja': 'はどうポケモン', 'zh-Hans': '波导宝可梦'}}
	public class SpecieLucario : PokemonSpecie
	{
#nullable enable
		private static SpecieLucario? _instance = null;
#nullable restore
        public static SpecieLucario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLucario();
                }
                return _instance;
            }
        }

		public SpecieLucario() : base(
			"Lucario",
			70, // HPs
			110, 70, // Attack & Defense
			115, 70, // Special Attack & Defense
			90			
		) {}
	}


	//Lucario Pokemon Class
	public class Lucario : Pokemon
	{

		public Lucario(string nickname, int level)
		: base(
				448,
				SpecieLucario.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lucario(int level)
		: base(
				448,
				SpecieLucario.Instance, // Pokemon Specie
				"Lucario", level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lucario() : base(
			448,
			SpecieLucario.Instance, // Pokemon Specie
			Fighting.Instance, Steel.Instance			
		) {}
	}
}