using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dwebble Specie to store common natural stats of every {'abilities': ['sturdy', 'shell-armor', 'weak-armor'], 'base_experience': 65, 'height': 3, 'id': 557, 'moves': ['swords-dance', 'cut', 'sand-attack', 'counter', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'spikes', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'facade', 'nature-power', 'knock-off', 'secret-power', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'iron-defense', 'block', 'rock-blast', 'rock-polish', 'poison-jab', 'night-slash', 'x-scissor', 'shadow-claw', 'rock-wrecker', 'stone-edge', 'stealth-rock', 'bug-bite', 'hone-claws', 'wide-guard', 'smack-down', 'round', 'shell-smash', 'struggle-bug', 'bulldoze', 'rototiller', 'confide'], 'name': 'dwebble', 'stats': {'hp': 50, 'attack': 65, 'defense': 85, 'special-attack': 35, 'special-defense': 35, 'speed': 55}, 'types': ['bug', 'rock'], 'weight': 145, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'red', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug', 'mineral'], 'names': {'ja-Hrkt': 'イシズマイ', 'ko': '돌살이', 'zh-Hant': '石居蟹', 'fr': 'Crabicoque', 'de': 'Lithomith', 'es': 'Dwebble', 'it': 'Dwebble', 'en': 'Dwebble', 'ja': 'イシズマイ', 'zh-Hans': '石居蟹'}, 'genera': {'ja-Hrkt': 'いしやどポケモン', 'ko': '돌집포켓몬', 'zh-Hant': '石居寶可夢', 'fr': 'Pokémon Lithicole', 'de': 'Steinhaus', 'es': 'Pokémon Casapiedra', 'it': 'Pokémon Pietracasa', 'en': 'Rock Inn Pokémon', 'ja': 'いしやどポケモン', 'zh-Hans': '石居宝可梦'}}
	public class SpecieDwebble : PokemonSpecie
	{
#nullable enable
		private static SpecieDwebble? _instance = null;
#nullable restore
        public static SpecieDwebble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDwebble();
                }
                return _instance;
            }
        }

		public SpecieDwebble() : base(
			"Dwebble",
			50, // HPs
			65, 85, // Attack & Defense
			35, 35, // Special Attack & Defense
			55			
		) {}
	}


	//Dwebble Pokemon Class
	public class Dwebble : Pokemon
	{

		public Dwebble(string nickname, int level) : base(
			557,
			SpecieDwebble.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Rock.Instance			
		) {}

		public Dwebble() : base(
			557,
			SpecieDwebble.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
	}
}