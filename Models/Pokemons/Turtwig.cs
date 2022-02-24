using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Turtwig Specie to store common natural stats of every {'abilities': ['overgrow', 'shell-armor'], 'base_experience': 64, 'height': 4, 'id': 387, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'body-slam', 'thrash', 'double-edge', 'bite', 'strength', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'withdraw', 'light-screen', 'reflect', 'amnesia', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'nature-power', 'superpower', 'secret-power', 'tickle', 'sand-tomb', 'bullet-seed', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'earth-power', 'rock-climb', 'leaf-storm', 'captivate', 'stealth-rock', 'grass-knot', 'wide-guard', 'heavy-slam', 'round', 'grass-pledge', 'work-up', 'grassy-terrain', 'confide'], 'name': 'turtwig', 'stats': {'hp': 55, 'attack': 68, 'defense': 64, 'special-attack': 45, 'special-defense': 55, 'speed': 31}, 'types': ['grass'], 'weight': 102, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ナエトル', 'roomaji': 'Naetle', 'ko': '모부기', 'zh-Hant': '草苗龜', 'fr': 'Tortipouss', 'de': 'Chelast', 'es': 'Turtwig', 'it': 'Turtwig', 'en': 'Turtwig', 'ja': 'ナエトル', 'zh-Hans': '草苗龟'}, 'genera': {'ja-Hrkt': 'わかばポケモン', 'ko': '어린잎포켓몬', 'zh-Hant': '嫩葉寶可夢', 'fr': 'Pokémon Minifeuille', 'de': 'Winziglaub', 'es': 'Pokémon Hojita', 'it': 'Pokémon Fogliolina', 'en': 'Tiny Leaf Pokémon', 'ja': 'わかばポケモン', 'zh-Hans': '嫩叶宝可梦'}}
	public class SpecieTurtwig : PokemonSpecie
	{
#nullable enable
		private static SpecieTurtwig? _instance = null;
#nullable restore
        public static SpecieTurtwig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTurtwig();
                }
                return _instance;
            }
        }

		public SpecieTurtwig() : base(
			"Turtwig",
			55, // HPs
			68, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
			31			
		) {}
	}


	//Turtwig Pokemon Class
	public class Turtwig : Pokemon
	{

		public Turtwig(string nickname, int level)
		: base(
				387,
				SpecieTurtwig.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Turtwig() : base(
			387,
			SpecieTurtwig.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}