using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Durant Specie to store common natural stats of every {'abilities': ['swarm', 'hustle', 'truant'], 'base_experience': 169, 'height': 3, 'id': 632, 'moves': ['vice-grip', 'guillotine', 'cut', 'sand-attack', 'bite', 'strength', 'thunder-wave', 'dig', 'toxic', 'agility', 'screech', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'feint-attack', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'metal-claw', 'hidden-power', 'crunch', 'rock-smash', 'facade', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'rock-polish', 'x-scissor', 'energy-ball', 'giga-impact', 'shadow-claw', 'thunder-fang', 'flash-cannon', 'rock-climb', 'iron-head', 'stone-edge', 'bug-bite', 'hone-claws', 'entrainment', 'round', 'retaliate', 'struggle-bug', 'confide'], 'name': 'durant', 'stats': {'hp': 58, 'attack': 109, 'defense': 112, 'special-attack': 48, 'special-defense': 48, 'speed': 109}, 'types': ['bug', 'steel'], 'weight': 330, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'gray', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'アイアント', 'ko': '아이앤트', 'zh-Hant': '鐵蟻', 'fr': 'Fermite', 'de': 'Fermicula', 'es': 'Durant', 'it': 'Durant', 'en': 'Durant', 'ja': 'アイアント', 'zh-Hans': '铁蚁'}, 'genera': {'ja-Hrkt': 'てつアリポケモン', 'ko': '철개미포켓몬', 'zh-Hant': '鐵蟻寶可夢', 'fr': 'Pokémon Fourmi Dure', 'de': 'Eisenameise', 'es': 'Pokémon Hormigacero', 'it': 'Pokémon Ferformica', 'en': 'Iron Ant Pokémon', 'ja': 'てつアリポケモン', 'zh-Hans': '铁蚁宝可梦'}}
	public class SpecieDurant : PokemonSpecie
	{
#nullable enable
		private static SpecieDurant? _instance = null;
#nullable restore
        public static SpecieDurant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDurant();
                }
                return _instance;
            }
        }

		public SpecieDurant() : base(
			"Durant",
			58, // HPs
			109, 112, // Attack & Defense
			48, 48, // Special Attack & Defense
			109			
		) {}
	}


	//Durant Pokemon Class
	public class Durant : Pokemon
	{

		public Durant(string nickname, int level) : base(
			632,
			SpecieDurant.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Steel.Instance			
		) {}

		public Durant() : base(
			632,
			SpecieDurant.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
	}
}