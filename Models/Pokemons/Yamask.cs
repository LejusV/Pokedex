using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yamask Specie to store common natural stats of every {'abilities': ['mummy'], 'base_experience': 61, 'height': 5, 'id': 562, 'moves': ['disable', 'toxic', 'psychic', 'night-shade', 'double-team', 'haze', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'destiny-bond', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'will-o-wisp', 'memento', 'facade', 'trick', 'role-play', 'magic-coat', 'knock-off', 'skill-swap', 'imprison', 'grudge', 'snatch', 'secret-power', 'astonish', 'fake-tears', 'iron-defense', 'block', 'calm-mind', 'shock-wave', 'payback', 'embargo', 'heal-block', 'toxic-spikes', 'dark-pulse', 'energy-ball', 'nasty-plot', 'zen-headbutt', 'trick-room', 'ominous-wind', 'guard-split', 'power-split', 'wonder-room', 'telekinesis', 'after-you', 'round', 'ally-switch', 'hex', 'crafty-shield', 'confide', 'infestation'], 'name': 'yamask', 'stats': {'hp': 38, 'attack': 30, 'defense': 85, 'special-attack': 55, 'special-defense': 65, 'speed': 30}, 'types': ['ghost'], 'weight': 15, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 190, 'color': 'black', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral', 'indeterminate'], 'names': {'ja-Hrkt': 'デスマス', 'ko': '데스마스', 'zh-Hant': '哭哭面具', 'fr': 'Tutafeh', 'de': 'Makabaja', 'es': 'Yamask', 'it': 'Yamask', 'en': 'Yamask', 'ja': 'デスマス', 'zh-Hans': '哭哭面具'}, 'genera': {'ja-Hrkt': 'たましいポケモン', 'ko': '영혼포켓몬', 'zh-Hant': '魂寶可夢', 'fr': 'Pokémon Âme', 'de': 'Seele', 'es': 'Pokémon Espíritu', 'it': 'Pokémon Fatuanima', 'en': 'Spirit Pokémon', 'ja': 'たましいポケモン', 'zh-Hans': '魂宝可梦'}}
	public class SpecieYamask : PokemonSpecie
	{
#nullable enable
		private static SpecieYamask? _instance = null;
#nullable restore
        public static SpecieYamask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYamask();
                }
                return _instance;
            }
        }

		public SpecieYamask() : base(
			"Yamask",
			38, // HPs
			30, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			30			
		) {}
	}


	//Yamask Pokemon Class
	public class Yamask : Pokemon
	{

		public Yamask(string nickname, int level)
		: base(
				562,
				SpecieYamask.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Yamask() : base(
			562,
			SpecieYamask.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}