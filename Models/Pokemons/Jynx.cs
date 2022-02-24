using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jynx Specie to store common natural stats of every {'abilities': ['oblivious', 'forewarn', 'dry-skin'], 'base_experience': 159, 'height': 14, 'id': 124, 'moves': ['pound', 'double-slap', 'mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'metronome', 'lick', 'skull-bash', 'dream-eater', 'lovely-kiss', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'powder-snow', 'protect', 'mud-slap', 'perish-song', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'dynamic-punch', 'sweet-scent', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'secret-power', 'hyper-voice', 'fake-tears', 'signal-beam', 'covet', 'calm-mind', 'water-pulse', 'wake-up-slap', 'natural-gift', 'payback', 'fling', 'wring-out', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'avalanche', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'magic-room', 'round', 'echoed-voice', 'frost-breath', 'heart-stamp', 'draining-kiss', 'confide', 'power-up-punch', 'aurora-veil'], 'name': 'jynx', 'stats': {'hp': 65, 'attack': 50, 'defense': 35, 'special-attack': 115, 'special-defense': 95, 'speed': 95}, 'types': ['ice', 'psychic'], 'weight': 406, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 8, 'capture_rate': 45, 'color': 'red', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ルージュラ', 'roomaji': 'Rougela', 'ko': '루주라', 'zh-Hant': '迷唇姐', 'fr': 'Lippoutou', 'de': 'Rossana', 'es': 'Jynx', 'it': 'Jynx', 'en': 'Jynx', 'ja': 'ルージュラ', 'zh-Hans': '迷唇姐'}, 'genera': {'ja-Hrkt': 'ひとがたポケモン', 'ko': '인간형태포켓몬', 'zh-Hant': '人形寶可夢', 'fr': 'Pokémon Humanoïde', 'de': 'Humanotyp', 'es': 'Pokémon Forma Humana', 'it': 'Pokémon Umanoide', 'en': 'Human Shape Pokémon', 'ja': 'ひとがたポケモン', 'zh-Hans': '人形宝可梦'}}
	public class SpecieJynx : PokemonSpecie
	{
#nullable enable
		private static SpecieJynx? _instance = null;
#nullable restore
        public static SpecieJynx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJynx();
                }
                return _instance;
            }
        }

		public SpecieJynx() : base(
			"Jynx",
			65, // HPs
			50, 35, // Attack & Defense
			115, 95, // Special Attack & Defense
			95			
		) {}
	}


	//Jynx Pokemon Class
	public class Jynx : Pokemon
	{

		public Jynx(string nickname, int level)
		: base(
				124,
				SpecieJynx.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jynx() : base(
			124,
			SpecieJynx.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
	}
}