using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spoink Specie to store common natural stats of every {'abilities': ['thick-fat', 'own-tempo', 'gluttony'], 'base_experience': 66, 'height': 7, 'id': 325, 'moves': ['whirlwind', 'headbutt', 'body-slam', 'double-edge', 'psybeam', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'swift', 'amnesia', 'dream-eater', 'flash', 'psywave', 'splash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'facade', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'snatch', 'secret-power', 'odor-sleuth', 'signal-beam', 'extrasensory', 'bounce', 'covet', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'lucky-chant', 'power-gem', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'simple-beam', 'round', 'confide'], 'name': 'spoink', 'stats': {'hp': 60, 'attack': 25, 'defense': 35, 'special-attack': 70, 'special-defense': 80, 'speed': 60}, 'types': ['psychic'], 'weight': 306, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'black', 'shape': 'arms', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バネブー', 'roomaji': 'Baneboo', 'ko': '피그점프', 'zh-Hant': '跳跳豬', 'fr': 'Spoink', 'de': 'Spoink', 'es': 'Spoink', 'it': 'Spoink', 'en': 'Spoink', 'ja': 'バネブー', 'zh-Hans': '跳跳猪'}, 'genera': {'ja-Hrkt': 'とびはねポケモン', 'ko': '튀다포켓몬', 'zh-Hant': '彈跳寶可夢', 'fr': 'Pokémon Rebond', 'de': 'Sprungfeder', 'es': 'Pokémon Saltarín', 'it': 'Pokémon Molla', 'en': 'Bounce Pokémon', 'ja': 'とびはねポケモン', 'zh-Hans': '弹跳宝可梦'}}
	public class SpecieSpoink : PokemonSpecie
	{
#nullable enable
		private static SpecieSpoink? _instance = null;
#nullable restore
        public static SpecieSpoink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpoink();
                }
                return _instance;
            }
        }

		public SpecieSpoink() : base(
			"Spoink",
			60, // HPs
			25, 35, // Attack & Defense
			70, 80, // Special Attack & Defense
			60			
		) {}
	}


	//Spoink Pokemon Class
	public class Spoink : Pokemon
	{

		public Spoink(string nickname, int level) : base(
			325,
			SpecieSpoink.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Spoink() : base(
			325,
			SpecieSpoink.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}