using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ralts Specie to store common natural stats of every {'abilities': ['synchronize', 'trace', 'telepathy'], 'base_experience': 40, 'height': 4, 'id': 280, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'growl', 'disable', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'teleport', 'mimic', 'double-team', 'confuse-ray', 'defense-curl', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'protect', 'mud-slap', 'destiny-bond', 'icy-wind', 'endure', 'charm', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'helping-hand', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'grudge', 'snatch', 'secret-power', 'hyper-voice', 'signal-beam', 'magical-leaf', 'calm-mind', 'shock-wave', 'natural-gift', 'fling', 'lucky-chant', 'shadow-sneak', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'synchronoise', 'round', 'echoed-voice', 'stored-power', 'ally-switch', 'heal-pulse', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'confide', 'dazzling-gleam'], 'name': 'ralts', 'stats': {'hp': 28, 'attack': 25, 'defense': 25, 'special-attack': 45, 'special-defense': 35, 'speed': 40}, 'types': ['psychic', 'fairy'], 'weight': 66, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 235, 'color': 'white', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ラルトス', 'roomaji': 'Ralts', 'ko': '랄토스', 'zh-Hant': '拉魯拉絲', 'fr': 'Tarsal', 'de': 'Trasla', 'es': 'Ralts', 'it': 'Ralts', 'en': 'Ralts', 'ja': 'ラルトス', 'zh-Hans': '拉鲁拉丝'}, 'genera': {'ja-Hrkt': 'きもちポケモン', 'ko': '느낌포켓몬', 'zh-Hant': '心情寶可夢', 'fr': 'Pokémon Sentiment', 'de': 'Gefühl', 'es': 'Pokémon Sensible', 'it': 'Pokémon Sensazione', 'en': 'Feeling Pokémon', 'ja': 'きもちポケモン', 'zh-Hans': '心情宝可梦'}}
	public class SpecieRalts : PokemonSpecie
	{
#nullable enable
		private static SpecieRalts? _instance = null;
#nullable restore
        public static SpecieRalts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRalts();
                }
                return _instance;
            }
        }

		public SpecieRalts() : base(
			"Ralts",
			28, // HPs
			25, 25, // Attack & Defense
			45, 35, // Special Attack & Defense
			40			
		) {}
	}


	//Ralts Pokemon Class
	public class Ralts : Pokemon
	{

		public Ralts(string nickname, int level)
		: base(
				280,
				SpecieRalts.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ralts() : base(
			280,
			SpecieRalts.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}