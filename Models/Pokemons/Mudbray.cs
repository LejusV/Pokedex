using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mudbray Specie to store common natural stats of every {'abilities': ['own-tempo', 'stamina', 'inner-focus'], 'base_experience': 77, 'height': 10, 'id': 749, 'moves': ['stomp', 'double-kick', 'mega-kick', 'body-slam', 'double-edge', 'roar', 'counter', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'protect', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'facade', 'superpower', 'mud-sport', 'rock-tomb', 'iron-defense', 'close-combat', 'payback', 'mud-bomb', 'heavy-slam', 'low-sweep', 'round', 'bulldoze', 'rototiller', 'confide', 'high-horsepower'], 'name': 'mudbray', 'stats': {'hp': 70, 'attack': 100, 'defense': 70, 'special-attack': 45, 'special-defense': 55, 'speed': 45}, 'types': ['ground'], 'weight': 1100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ドロバンコ', 'ko': '머드나기', 'zh-Hant': '泥驢仔', 'fr': 'Tiboudet', 'de': 'Pampuli', 'es': 'Mudbray', 'it': 'Mudbray', 'en': 'Mudbray', 'ja': 'ドロバンコ', 'zh-Hans': '泥驴仔'}, 'genera': {'ja-Hrkt': 'うさぎうまポケモン', 'ko': '당나귀포켓몬', 'zh-Hant': '驢寶可夢', 'fr': 'Pokémon Âne', 'de': 'Packesel', 'es': 'Pokémon Asno', 'it': 'Pokémon Ciuconiglio', 'en': 'Donkey Pokémon', 'ja': 'うさぎうまポケモン', 'zh-Hans': '驴宝可梦'}}
	public class SpecieMudbray : PokemonSpecie
	{
#nullable enable
		private static SpecieMudbray? _instance = null;
#nullable restore
        public static SpecieMudbray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudbray();
                }
                return _instance;
            }
        }

		public SpecieMudbray() : base(
			"Mudbray",
			70, // HPs
			100, 70, // Attack & Defense
			45, 55, // Special Attack & Defense
			45			
		) {}
	}


	//Mudbray Pokemon Class
	public class Mudbray : Pokemon
	{

		public Mudbray(string nickname, int level) : base(
			749,
			SpecieMudbray.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Mudbray() : base(
			749,
			SpecieMudbray.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}