using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magmar Specie to store common natural stats of every {'abilities': ['flame-body', 'vital-spirit'], 'base_experience': 173, 'height': 13, 'id': 126, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'ember', 'flamethrower', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'fire-spin', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'smokescreen', 'confuse-ray', 'bide', 'metronome', 'smog', 'fire-blast', 'skull-bash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'overheat', 'covet', 'natural-gift', 'fling', 'focus-blast', 'giga-impact', 'rock-climb', 'lava-plume', 'captivate', 'flame-burst', 'flame-charge', 'low-sweep', 'round', 'clear-smog', 'incinerate', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'magmar', 'stats': {'hp': 65, 'attack': 95, 'defense': 57, 'special-attack': 100, 'special-defense': 85, 'speed': 93}, 'types': ['fire'], 'weight': 445, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ブーバー', 'roomaji': 'Boober', 'ko': '마그마', 'zh-Hant': '鴨嘴火獸', 'fr': 'Magmar', 'de': 'Magmar', 'es': 'Magmar', 'it': 'Magmar', 'en': 'Magmar', 'ja': 'ブーバー', 'zh-Hans': '鸭嘴火兽'}, 'genera': {'ja-Hrkt': 'ひふきポケモン', 'ko': '불뿜기포켓몬', 'zh-Hant': '吐火寶可夢', 'fr': 'Pokémon Crache-Feu', 'de': 'Brenner', 'es': 'Pokémon Escupefuego', 'it': 'Pokémon Sputafuoco', 'en': 'Spitfire Pokémon', 'ja': 'ひふきポケモン', 'zh-Hans': '吐火宝可梦'}}
	public class SpecieMagmar : PokemonSpecie
	{
#nullable enable
		private static SpecieMagmar? _instance = null;
#nullable restore
        public static SpecieMagmar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagmar();
                }
                return _instance;
            }
        }

		public SpecieMagmar() : base(
			"Magmar",
			65, // HPs
			95, 57, // Attack & Defense
			100, 85, // Special Attack & Defense
			93			
		) {}
	}


	//Magmar Pokemon Class
	public class Magmar : Pokemon
	{

		public Magmar(string nickname, int level)
		: base(
				126,
				SpecieMagmar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Magmar() : base(
			126,
			SpecieMagmar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}