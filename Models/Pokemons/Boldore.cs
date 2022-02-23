using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Boldore Specie to store common natural stats of every {'abilities': ['sturdy', 'weak-armor', 'sand-force'], 'base_experience': 137, 'height': 9, 'id': 525, 'moves': ['sand-attack', 'headbutt', 'tackle', 'strength', 'earthquake', 'toxic', 'double-team', 'harden', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'facade', 'nature-power', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'gravity', 'rock-polish', 'power-gem', 'earth-power', 'flash-cannon', 'stone-edge', 'stealth-rock', 'smack-down', 'round', 'bulldoze', 'confide'], 'name': 'boldore', 'stats': {'hp': 70, 'attack': 105, 'defense': 105, 'special-attack': 50, 'special-defense': 40, 'speed': 20}, 'types': ['rock'], 'weight': 1020, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ガントル', 'ko': '암트르', 'zh-Hant': '地幔岩', 'fr': 'Géolithe', 'de': 'Sedimantur', 'es': 'Boldore', 'it': 'Boldore', 'en': 'Boldore', 'ja': 'ガントル', 'zh-Hans': '地幔岩'}, 'genera': {'ja-Hrkt': 'こうせきポケモン', 'ko': '광석포켓몬', 'zh-Hant': '礦石寶可夢', 'fr': 'Pokémon Minerai', 'de': 'Erz', 'es': 'Pokémon Mineral', 'it': 'Pokémon Minerale', 'en': 'Ore Pokémon', 'ja': 'こうせきポケモン', 'zh-Hans': '矿石宝可梦'}}
	public class SpecieBoldore : PokemonSpecie
	{
#nullable enable
		private static SpecieBoldore? _instance = null;
#nullable restore
        public static SpecieBoldore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBoldore();
                }
                return _instance;
            }
        }

		public SpecieBoldore() : base(
			"Boldore",
			70, // HPs
			105, 105, // Attack & Defense
			50, 40, // Special Attack & Defense
			20			
		) {}
	}


	//Boldore Pokemon Class
	public class Boldore : Pokemon
	{

		public Boldore(string nickname, int level) : base(
			525,
			SpecieBoldore.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Boldore() : base(
			525,
			SpecieBoldore.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}