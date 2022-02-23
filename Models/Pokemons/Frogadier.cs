using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Frogadier Specie to store common natural stats of every {'abilities': ['torrent', 'protean'], 'base_experience': 142, 'height': 6, 'id': 657, 'moves': ['pound', 'ice-punch', 'cut', 'growl', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'strength', 'dig', 'toxic', 'quick-attack', 'double-team', 'smokescreen', 'lick', 'waterfall', 'bubble', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'taunt', 'role-play', 'snatch', 'secret-power', 'dive', 'rock-tomb', 'aerial-ace', 'bounce', 'water-pulse', 'u-turn', 'fling', 'dark-pulse', 'gunk-shot', 'grass-knot', 'smack-down', 'round', 'echoed-voice', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'frogadier', 'stats': {'hp': 54, 'attack': 63, 'defense': 52, 'special-attack': 83, 'special-defense': 56, 'speed': 97}, 'types': ['water'], 'weight': 109, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ゲコガシラ', 'ko': '개굴반장', 'zh-Hant': '呱頭蛙', 'fr': 'Croâporal', 'de': 'Amphizel', 'es': 'Frogadier', 'it': 'Frogadier', 'en': 'Frogadier', 'ja': 'ゲコガシラ', 'zh-Hans': '呱头蛙'}, 'genera': {'ja-Hrkt': 'あわがえるポケモン', 'ko': '거품개구리포켓몬', 'zh-Hant': '泡蛙寶可夢', 'fr': 'Pokémon Crapobulle', 'de': 'Blubbfrosch', 'es': 'Pokémon Burburrana', 'it': 'Pokémon Schiumorana', 'en': 'Bubble Frog Pokémon', 'ja': 'あわがえるポケモン', 'zh-Hans': '泡蛙宝可梦'}}
	public class SpecieFrogadier : PokemonSpecie
	{
#nullable enable
		private static SpecieFrogadier? _instance = null;
#nullable restore
        public static SpecieFrogadier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrogadier();
                }
                return _instance;
            }
        }

		public SpecieFrogadier() : base(
			"Frogadier",
			54, // HPs
			63, 52, // Attack & Defense
			83, 56, // Special Attack & Defense
			97			
		) {}
	}


	//Frogadier Pokemon Class
	public class Frogadier : Pokemon
	{

		public Frogadier(string nickname, int level) : base(
			657,
			SpecieFrogadier.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Frogadier() : base(
			657,
			SpecieFrogadier.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}