using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mime-Jr Specie to store common natural stats of every {'abilities': ['soundproof', 'filter', 'technician'], 'base_experience': 62, 'height': 6, 'id': 439, 'moves': ['pound', 'double-slap', 'headbutt', 'psybeam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'hypnosis', 'meditate', 'mimic', 'double-team', 'confuse-ray', 'barrier', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'fake-out', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'teeter-dance', 'tickle', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'wake-up-slap', 'healing-wish', 'natural-gift', 'fling', 'copycat', 'drain-punch', 'nasty-plot', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'round', 'confide', 'infestation', 'psychic-terrain'], 'name': 'mime-jr', 'stats': {'hp': 20, 'attack': 25, 'defense': 45, 'special-attack': 70, 'special-defense': 90, 'speed': 60}, 'types': ['psychic', 'fairy'], 'weight': 130, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 145, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'マネネ', 'roomaji': 'Manene', 'ko': '흉내내', 'zh-Hant': '魔尼尼', 'fr': 'Mime Jr.', 'de': 'Pantimimi', 'es': 'Mime Jr.', 'it': 'Mime Jr.', 'en': 'Mime Jr.', 'ja': 'マネネ', 'zh-Hans': '魔尼尼'}, 'genera': {'ja-Hrkt': 'マイムポケモン', 'ko': '따라하기포켓몬', 'zh-Hant': '默劇寶可夢', 'fr': 'Pokémon Mime', 'de': 'Mime', 'es': 'Pokémon Mimo', 'it': 'Pokémon Mimo', 'en': 'Mime Pokémon', 'ja': 'マイムポケモン', 'zh-Hans': '默剧宝可梦'}}
	public class SpecieMimeJr : PokemonSpecie
	{
#nullable enable
		private static SpecieMimeJr? _instance = null;
#nullable restore
        public static SpecieMimeJr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMimeJr();
                }
                return _instance;
            }
        }

		public SpecieMimeJr() : base(
			"Mime-Jr",
			20, // HPs
			25, 45, // Attack & Defense
			70, 90, // Special Attack & Defense
			60			
		) {}
	}


	//Mime-Jr Pokemon Class
	public class MimeJr : Pokemon
	{

		public MimeJr(string nickname, int level)
		: base(
				439,
				SpecieMimeJr.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MimeJr() : base(
			439,
			SpecieMimeJr.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}