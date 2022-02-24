using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Torracat Specie to store common natural stats of every {'abilities': ['blaze', 'intimidate'], 'base_experience': 147, 'height': 7, 'id': 726, 'moves': ['scratch', 'swords-dance', 'double-kick', 'thrash', 'leer', 'bite', 'growl', 'roar', 'ember', 'flamethrower', 'toxic', 'double-team', 'lick', 'fire-blast', 'leech-life', 'fury-swipes', 'rest', 'substitute', 'protect', 'scary-face', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'torment', 'will-o-wisp', 'facade', 'taunt', 'overheat', 'bulk-up', 'u-turn', 'flare-blitz', 'shadow-claw', 'fire-fang', 'flame-charge', 'round', 'acrobatics', 'fire-pledge', 'work-up', 'confide'], 'name': 'torracat', 'stats': {'hp': 65, 'attack': 85, 'defense': 50, 'special-attack': 80, 'special-defense': 50, 'speed': 90}, 'types': ['fire'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャヒート', 'ko': '냐오히트', 'zh-Hant': '炎熱喵', 'fr': 'Matoufeu', 'de': 'Miezunder', 'es': 'Torracat', 'it': 'Torracat', 'en': 'Torracat', 'ja': 'ニャヒート', 'zh-Hans': '炎热喵'}, 'genera': {'ja-Hrkt': 'ひねこポケモン', 'ko': '불고양이포켓몬', 'zh-Hant': '火貓寶可夢', 'fr': 'Pokémon Chat Feu', 'de': 'Feuerkatze', 'es': 'Pokémon Gato Fuego', 'it': 'Pokémon Pirofelino', 'en': 'Fire Cat Pokémon', 'ja': 'ひねこポケモン', 'zh-Hans': '火猫宝可梦'}}
	public class SpecieTorracat : PokemonSpecie
	{
#nullable enable
		private static SpecieTorracat? _instance = null;
#nullable restore
        public static SpecieTorracat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorracat();
                }
                return _instance;
            }
        }

		public SpecieTorracat() : base(
			"Torracat",
			65, // HPs
			85, 50, // Attack & Defense
			80, 50, // Special Attack & Defense
			90			
		) {}
	}


	//Torracat Pokemon Class
	public class Torracat : Pokemon
	{

		public Torracat(string nickname, int level)
		: base(
				726,
				SpecieTorracat.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Torracat(int level)
		: base(
				726,
				SpecieTorracat.Instance, // Pokemon Specie
				"Torracat", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Torracat() : base(
			726,
			SpecieTorracat.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}