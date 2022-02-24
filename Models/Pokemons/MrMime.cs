using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mr-Mime Specie to store common natural stats of every {'abilities': ['soundproof', 'filter', 'technician'], 'base_experience': 161, 'height': 13, 'id': 122, 'moves': ['pound', 'double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'psybeam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'hypnosis', 'meditate', 'rage', 'teleport', 'mimic', 'double-team', 'confuse-ray', 'barrier', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'baton-pass', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'fake-out', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'teeter-dance', 'signal-beam', 'aerial-ace', 'iron-defense', 'covet', 'magical-leaf', 'calm-mind', 'shock-wave', 'wake-up-slap', 'natural-gift', 'payback', 'fling', 'copycat', 'power-swap', 'guard-swap', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wide-guard', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'quick-guard', 'misty-terrain', 'confide', 'dazzling-gleam', 'infestation', 'power-up-punch', 'psychic-terrain'], 'name': 'mr-mime', 'stats': {'hp': 40, 'attack': 45, 'defense': 65, 'special-attack': 100, 'special-defense': 120, 'speed': 90}, 'types': ['psychic', 'fairy'], 'weight': 545, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'バリヤード', 'roomaji': 'Barrierd', 'ko': '마임맨', 'zh-Hant': '魔牆人偶', 'fr': 'M. Mime', 'de': 'Pantimos', 'es': 'Mr. Mime', 'it': 'Mr. Mime', 'en': 'Mr. Mime', 'ja': 'バリヤード', 'zh-Hans': '魔墙人偶'}, 'genera': {'ja-Hrkt': 'バリアーポケモン', 'ko': '배리어포켓몬', 'zh-Hant': '屏障寶可夢', 'fr': 'Pokémon Bloqueur', 'de': 'Sperre', 'es': 'Pokémon Barrera', 'it': 'Pokémon Barriera', 'en': 'Barrier Pokémon', 'ja': 'バリアーポケモン', 'zh-Hans': '屏障宝可梦'}}
	public class SpecieMrMime : PokemonSpecie
	{
#nullable enable
		private static SpecieMrMime? _instance = null;
#nullable restore
        public static SpecieMrMime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMrMime();
                }
                return _instance;
            }
        }

		public SpecieMrMime() : base(
			"Mr-Mime",
			40, // HPs
			45, 65, // Attack & Defense
			100, 120, // Special Attack & Defense
			90			
		) {}
	}


	//Mr-Mime Pokemon Class
	public class MrMime : Pokemon
	{

		public MrMime(string nickname, int level)
		: base(
				122,
				SpecieMrMime.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MrMime(int level)
		: base(
				122,
				SpecieMrMime.Instance, // Pokemon Specie
				"Mr-Mime", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MrMime() : base(
			122,
			SpecieMrMime.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}