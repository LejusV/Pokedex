using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Torterra Specie to store common natural stats of every {'abilities': ['overgrow', 'shell-armor'], 'base_experience': 236, 'height': 22, 'id': 389, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'bite', 'roar', 'hyper-beam', 'strength', 'absorb', 'mega-drain', 'leech-seed', 'razor-leaf', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'withdraw', 'light-screen', 'reflect', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'outrage', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'nature-power', 'superpower', 'secret-power', 'rock-tomb', 'bullet-seed', 'block', 'frenzy-plant', 'natural-gift', 'worry-seed', 'rock-polish', 'seed-bomb', 'energy-ball', 'earth-power', 'giga-impact', 'rock-climb', 'leaf-storm', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'grass-knot', 'wood-hammer', 'round', 'grass-pledge', 'bulldoze', 'work-up', 'confide'], 'name': 'torterra', 'stats': {'hp': 95, 'attack': 109, 'defense': 105, 'special-attack': 75, 'special-defense': 85, 'speed': 56}, 'types': ['grass', 'ground'], 'weight': 3100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ドダイトス', 'roomaji': 'Dodaitose', 'ko': '토대부기', 'zh-Hant': '土台龜', 'fr': 'Torterra', 'de': 'Chelterrar', 'es': 'Torterra', 'it': 'Torterra', 'en': 'Torterra', 'ja': 'ドダイトス', 'zh-Hans': '土台龟'}, 'genera': {'ja-Hrkt': 'たいりくポケモン', 'ko': '대륙포켓몬', 'zh-Hant': '大陸寶可夢', 'fr': 'Pokémon Continent', 'de': 'Kontinent', 'es': 'Pokémon Continente', 'it': 'Pokémon Continente', 'en': 'Continent Pokémon', 'ja': 'たいりくポケモン', 'zh-Hans': '大陆宝可梦'}}
	public class SpecieTorterra : PokemonSpecie
	{
#nullable enable
		private static SpecieTorterra? _instance = null;
#nullable restore
        public static SpecieTorterra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorterra();
                }
                return _instance;
            }
        }

		public SpecieTorterra() : base(
			"Torterra",
			95, // HPs
			109, 105, // Attack & Defense
			75, 85, // Special Attack & Defense
			56			
		) {}
	}


	//Torterra Pokemon Class
	public class Torterra : Pokemon
	{

		public Torterra(string nickname, int level) : base(
			389,
			SpecieTorterra.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Ground.Instance			
		) {}

		public Torterra() : base(
			389,
			SpecieTorterra.Instance, // Pokemon Specie
			Grass.Instance, Ground.Instance			
		) {}
	}
}