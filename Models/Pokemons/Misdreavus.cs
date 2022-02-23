using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Misdreavus Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 87, 'height': 7, 'id': 200, 'moves': ['headbutt', 'double-edge', 'growl', 'psybeam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'mimic', 'screech', 'double-team', 'confuse-ray', 'defense-curl', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'zap-cannon', 'destiny-bond', 'perish-song', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'trick', 'magic-coat', 'skill-swap', 'imprison', 'grudge', 'snatch', 'secret-power', 'hyper-voice', 'astonish', 'aerial-ace', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'embargo', 'me-first', 'sucker-punch', 'dark-pulse', 'power-gem', 'nasty-plot', 'shadow-sneak', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'wonder-room', 'telekinesis', 'magic-room', 'foul-play', 'round', 'echoed-voice', 'hex', 'confide', 'dazzling-gleam'], 'name': 'misdreavus', 'stats': {'hp': 60, 'attack': 60, 'defense': 60, 'special-attack': 85, 'special-defense': 85, 'speed': 85}, 'types': ['ghost'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'ball', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ムウマ', 'roomaji': 'Muma', 'ko': '무우마', 'zh-Hant': '夢妖', 'fr': 'Feuforêve', 'de': 'Traunfugil', 'es': 'Misdreavus', 'it': 'Misdreavus', 'en': 'Misdreavus', 'ja': 'ムウマ', 'zh-Hans': '梦妖'}, 'genera': {'ja-Hrkt': 'よなきポケモン', 'ko': '야명포켓몬', 'zh-Hant': '夜啼寶可夢', 'fr': 'Pokémon Strident', 'de': 'Kreischer', 'es': 'Pokémon Chirrido', 'it': 'Pokémon Strido', 'en': 'Screech Pokémon', 'ja': 'よなきポケモン', 'zh-Hans': '夜啼宝可梦'}}
	public class SpecieMisdreavus : PokemonSpecie
	{
#nullable enable
		private static SpecieMisdreavus? _instance = null;
#nullable restore
        public static SpecieMisdreavus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMisdreavus();
                }
                return _instance;
            }
        }

		public SpecieMisdreavus() : base(
			"Misdreavus",
			60, // HPs
			60, 60, // Attack & Defense
			85, 85, // Special Attack & Defense
			85			
		) {}
	}


	//Misdreavus Pokemon Class
	public class Misdreavus : Pokemon
	{

		public Misdreavus(string nickname, int level) : base(
			200,
			SpecieMisdreavus.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance			
		) {}

		public Misdreavus() : base(
			200,
			SpecieMisdreavus.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}