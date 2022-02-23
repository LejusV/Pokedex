using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shuckle Specie to store common natural stats of every {'abilities': ['sturdy', 'gluttony', 'contrary'], 'base_experience': 177, 'height': 6, 'id': 213, 'moves': ['bind', 'headbutt', 'body-slam', 'wrap', 'double-edge', 'acid', 'strength', 'string-shot', 'rock-throw', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'withdraw', 'defense-curl', 'bide', 'constrict', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'sweet-scent', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'helping-hand', 'knock-off', 'secret-power', 'rock-tomb', 'sand-tomb', 'rock-blast', 'gyro-ball', 'natural-gift', 'acupressure', 'power-trick', 'gastro-acid', 'rock-polish', 'earth-power', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'guard-split', 'power-split', 'venoshock', 'smack-down', 'sludge-wave', 'after-you', 'round', 'shell-smash', 'final-gambit', 'struggle-bug', 'bulldoze', 'sticky-web', 'confide', 'infestation'], 'name': 'shuckle', 'stats': {'hp': 20, 'attack': 10, 'defense': 230, 'special-attack': 10, 'special-defense': 230, 'speed': 5}, 'types': ['bug', 'rock'], 'weight': 205, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'armor', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ツボツボ', 'roomaji': 'Tsubotsubo', 'ko': '단단지', 'zh-Hant': '壺壺', 'fr': 'Caratroc', 'de': 'Pottrott', 'es': 'Shuckle', 'it': 'Shuckle', 'en': 'Shuckle', 'ja': 'ツボツボ', 'zh-Hans': '壶壶'}, 'genera': {'ja-Hrkt': 'はっこうポケモン', 'ko': '발효포켓몬', 'zh-Hant': '發酵寶可夢', 'fr': 'Pokémon Pourri', 'de': 'Schimmel', 'es': 'Pokémon Moho', 'it': 'Pokémon Muffa', 'en': 'Mold Pokémon', 'ja': 'はっこうポケモン', 'zh-Hans': '发酵宝可梦'}}
	public class SpecieShuckle : PokemonSpecie
	{
#nullable enable
		private static SpecieShuckle? _instance = null;
#nullable restore
        public static SpecieShuckle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShuckle();
                }
                return _instance;
            }
        }

		public SpecieShuckle() : base(
			"Shuckle",
			20, // HPs
			10, 230, // Attack & Defense
			10, 230, // Special Attack & Defense
			5			
		) {}
	}


	//Shuckle Pokemon Class
	public class Shuckle : Pokemon
	{

		public Shuckle(string nickname, int level) : base(
			213,
			SpecieShuckle.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Rock.Instance			
		) {}

		public Shuckle() : base(
			213,
			SpecieShuckle.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
	}
}