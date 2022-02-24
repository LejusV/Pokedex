using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gallade Specie to store common natural stats of every {'abilities': ['steadfast', 'justified'], 'base_experience': 233, 'height': 16, 'id': 475, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'headbutt', 'leer', 'hyper-beam', 'low-kick', 'strength', 'thunderbolt', 'thunder-wave', 'earthquake', 'toxic', 'confusion', 'psychic', 'teleport', 'double-team', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'trick', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'hyper-voice', 'rock-tomb', 'signal-beam', 'aerial-ace', 'bulk-up', 'calm-mind', 'leaf-blade', 'shock-wave', 'natural-gift', 'feint', 'close-combat', 'fling', 'poison-jab', 'night-slash', 'x-scissor', 'drain-punch', 'vacuum-wave', 'focus-blast', 'giga-impact', 'psycho-cut', 'zen-headbutt', 'trick-room', 'stone-edge', 'captivate', 'grass-knot', 'charge-beam', 'wide-guard', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'low-sweep', 'round', 'echoed-voice', 'stored-power', 'quick-guard', 'ally-switch', 'heal-pulse', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'gallade', 'stats': {'hp': 68, 'attack': 125, 'defense': 65, 'special-attack': 65, 'special-defense': 115, 'speed': 80}, 'types': ['psychic', 'fighting'], 'weight': 520, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'エルレイド', 'roomaji': 'Erlade', 'ko': '엘레이드', 'zh-Hant': '艾路雷朵', 'fr': 'Gallame', 'de': 'Galagladi', 'es': 'Gallade', 'it': 'Gallade', 'en': 'Gallade', 'ja': 'エルレイド', 'zh-Hans': '艾路雷朵'}, 'genera': {'ja-Hrkt': 'やいばポケモン', 'ko': '검포켓몬', 'zh-Hant': '利刃寶可夢', 'fr': 'Pokémon Lame', 'de': 'Klinge', 'es': 'Pokémon Cuchilla', 'it': 'Pokémon Lama', 'en': 'Blade Pokémon', 'ja': 'やいばポケモン', 'zh-Hans': '利刃宝可梦'}}
	public class SpecieGallade : PokemonSpecie
	{
#nullable enable
		private static SpecieGallade? _instance = null;
#nullable restore
        public static SpecieGallade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGallade();
                }
                return _instance;
            }
        }

		public SpecieGallade() : base(
			"Gallade",
			68, // HPs
			125, 65, // Attack & Defense
			65, 115, // Special Attack & Defense
			80			
		) {}
	}


	//Gallade Pokemon Class
	public class Gallade : Pokemon
	{

		public Gallade(string nickname, int level)
		: base(
				475,
				SpecieGallade.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gallade(int level)
		: base(
				475,
				SpecieGallade.Instance, // Pokemon Specie
				"Gallade", level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gallade() : base(
			475,
			SpecieGallade.Instance, // Pokemon Specie
			Psychic.Instance, Fighting.Instance			
		) {}
	}
}