using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hippowdon Specie to store common natural stats of every {'abilities': ['sand-stream', 'sand-force'], 'base_experience': 184, 'height': 20, 'id': 450, 'moves': ['sand-attack', 'headbutt', 'tackle', 'take-down', 'double-edge', 'bite', 'roar', 'hyper-beam', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'superpower', 'yawn', 'secret-power', 'rock-tomb', 'sand-tomb', 'water-pulse', 'natural-gift', 'earth-power', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'round', 'bulldoze', 'confide'], 'name': 'hippowdon', 'stats': {'hp': 108, 'attack': 112, 'defense': 118, 'special-attack': 68, 'special-defense': 72, 'speed': 47}, 'types': ['ground'], 'weight': 3000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'カバルドン', 'roomaji': 'Kabarudon', 'ko': '하마돈', 'zh-Hant': '河馬獸', 'fr': 'Hippodocus', 'de': 'Hippoterus', 'es': 'Hippowdon', 'it': 'Hippowdon', 'en': 'Hippowdon', 'ja': 'カバルドン', 'zh-Hans': '河马兽'}, 'genera': {'ja-Hrkt': 'じゅうりょうポケモン', 'ko': '중량포켓몬', 'zh-Hant': '重量寶可夢', 'fr': 'Pokémon Poids Lourd', 'de': 'Schwergewicht', 'es': 'Pokémon Peso Pesado', 'it': 'Pokémon Grandepeso', 'en': 'Heavyweight Pokémon', 'ja': 'じゅうりょうポケモン', 'zh-Hans': '重量宝可梦'}}
	public class SpecieHippowdon : PokemonSpecie
	{
#nullable enable
		private static SpecieHippowdon? _instance = null;
#nullable restore
        public static SpecieHippowdon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHippowdon();
                }
                return _instance;
            }
        }

		public SpecieHippowdon() : base(
			"Hippowdon",
			108, // HPs
			112, 118, // Attack & Defense
			68, 72, // Special Attack & Defense
			47			
		) {}
	}


	//Hippowdon Pokemon Class
	public class Hippowdon : Pokemon
	{

		public Hippowdon(string nickname, int level)
		: base(
				450,
				SpecieHippowdon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hippowdon(int level)
		: base(
				450,
				SpecieHippowdon.Instance, // Pokemon Specie
				"Hippowdon", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hippowdon() : base(
			450,
			SpecieHippowdon.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}