using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shieldon Specie to store common natural stats of every {'abilities': ['sturdy', 'soundproof'], 'base_experience': 70, 'height': 5, 'id': 410, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'counter', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'screech', 'double-team', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'torment', 'facade', 'taunt', 'secret-power', 'rock-tomb', 'metal-sound', 'iron-defense', 'rock-blast', 'shock-wave', 'natural-gift', 'metal-burst', 'magnet-rise', 'rock-polish', 'earth-power', 'flash-cannon', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'wide-guard', 'guard-split', 'smack-down', 'heavy-slam', 'round', 'incinerate', 'bulldoze', 'confide'], 'name': 'shieldon', 'stats': {'hp': 30, 'attack': 42, 'defense': 118, 'special-attack': 42, 'special-defense': 88, 'speed': 30}, 'types': ['rock', 'steel'], 'weight': 570, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'タテトプス', 'roomaji': 'Tatetops', 'ko': '방패톱스', 'zh-Hant': '盾甲龍', 'fr': 'Dinoclier', 'de': 'Schilterus', 'es': 'Shieldon', 'it': 'Shieldon', 'en': 'Shieldon', 'ja': 'タテトプス', 'zh-Hans': '盾甲龙'}, 'genera': {'ja-Hrkt': 'シールドポケモン', 'ko': '실드포켓몬', 'zh-Hant': '護盾寶可夢', 'fr': 'Pokémon Bouclier', 'de': 'Schutzschild', 'es': 'Pokémon Escudo', 'it': 'Pokémon Schermo', 'en': 'Shield Pokémon', 'ja': 'シールドポケモン', 'zh-Hans': '护盾宝可梦'}}
	public class SpecieShieldon : PokemonSpecie
	{
#nullable enable
		private static SpecieShieldon? _instance = null;
#nullable restore
        public static SpecieShieldon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShieldon();
                }
                return _instance;
            }
        }

		public SpecieShieldon() : base(
			"Shieldon",
			30, // HPs
			42, 118, // Attack & Defense
			42, 88, // Special Attack & Defense
			30			
		) {}
	}


	//Shieldon Pokemon Class
	public class Shieldon : Pokemon
	{

		public Shieldon(string nickname, int level) : base(
			410,
			SpecieShieldon.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Steel.Instance			
		) {}

		public Shieldon() : base(
			410,
			SpecieShieldon.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
	}
}