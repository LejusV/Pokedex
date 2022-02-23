using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gothorita Specie to store common natural stats of every {'abilities': ['frisk', 'competitive', 'shadow-tag'], 'base_experience': 137, 'height': 7, 'id': 575, 'moves': ['pound', 'double-slap', 'psybeam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'flatter', 'facade', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'snatch', 'secret-power', 'fake-tears', 'rock-tomb', 'tickle', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'payback', 'embargo', 'fling', 'heal-block', 'dark-pulse', 'energy-ball', 'zen-headbutt', 'trick-room', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'play-nice', 'confide'], 'name': 'gothorita', 'stats': {'hp': 60, 'attack': 45, 'defense': 70, 'special-attack': 75, 'special-defense': 85, 'speed': 55}, 'types': ['psychic'], 'weight': 180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 100, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ゴチミル', 'ko': '고디보미', 'zh-Hant': '哥德小童', 'fr': 'Mesmérella', 'de': 'Hypnomorba', 'es': 'Gothorita', 'it': 'Gothorita', 'en': 'Gothorita', 'ja': 'ゴチミル', 'zh-Hans': '哥德小童'}, 'genera': {'ja-Hrkt': 'あやつりポケモン', 'ko': '조작포켓몬', 'zh-Hant': '操縱寶可夢', 'fr': 'Pokémon Magouilleur', 'de': 'Manipulator', 'es': 'Pokémon Manipulador', 'it': 'Pokémon Raggiro', 'en': 'Manipulate Pokémon', 'ja': 'あやつりポケモン', 'zh-Hans': '操纵宝可梦'}}
	public class SpecieGothorita : PokemonSpecie
	{
#nullable enable
		private static SpecieGothorita? _instance = null;
#nullable restore
        public static SpecieGothorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothorita();
                }
                return _instance;
            }
        }

		public SpecieGothorita() : base(
			"Gothorita",
			60, // HPs
			45, 70, // Attack & Defense
			75, 85, // Special Attack & Defense
			55			
		) {}
	}


	//Gothorita Pokemon Class
	public class Gothorita : Pokemon
	{

		public Gothorita(string nickname, int level) : base(
			575,
			SpecieGothorita.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Gothorita() : base(
			575,
			SpecieGothorita.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}