using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hippopotas Specie to store common natural stats of every {'abilities': ['sand-stream', 'sand-force'], 'base_experience': 66, 'height': 8, 'id': 449, 'moves': ['whirlwind', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'bite', 'roar', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'superpower', 'revenge', 'yawn', 'secret-power', 'slack-off', 'rock-tomb', 'sand-tomb', 'water-pulse', 'natural-gift', 'earth-power', 'captivate', 'stealth-rock', 'round', 'bulldoze', 'confide'], 'name': 'hippopotas', 'stats': {'hp': 68, 'attack': 72, 'defense': 78, 'special-attack': 38, 'special-defense': 42, 'speed': 32}, 'types': ['ground'], 'weight': 495, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 140, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒポポタス', 'roomaji': 'Hipopotas', 'ko': '히포포타스', 'zh-Hant': '沙河馬', 'fr': 'Hippopotas', 'de': 'Hippopotas', 'es': 'Hippopotas', 'it': 'Hippopotas', 'en': 'Hippopotas', 'ja': 'ヒポポタス', 'zh-Hans': '沙河马'}, 'genera': {'ja-Hrkt': 'カバポケモン', 'ko': '하마포켓몬', 'zh-Hant': '河馬寶可夢', 'fr': 'Pokémon Hippo', 'de': 'Flusspferd', 'es': 'Pokémon Hipo', 'it': 'Pokémon Ippo', 'en': 'Hippo Pokémon', 'ja': 'カバポケモン', 'zh-Hans': '河马宝可梦'}}
	public class SpecieHippopotas : PokemonSpecie
	{
#nullable enable
		private static SpecieHippopotas? _instance = null;
#nullable restore
        public static SpecieHippopotas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHippopotas();
                }
                return _instance;
            }
        }

		public SpecieHippopotas() : base(
			"Hippopotas",
			68, // HPs
			72, 78, // Attack & Defense
			38, 42, // Special Attack & Defense
			32			
		) {}
	}


	//Hippopotas Pokemon Class
	public class Hippopotas : Pokemon
	{

		public Hippopotas(string nickname, int level) : base(
			449,
			SpecieHippopotas.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Hippopotas() : base(
			449,
			SpecieHippopotas.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}