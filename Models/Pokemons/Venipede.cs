using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venipede Specie to store common natural stats of every {'abilities': ['poison-point', 'swarm', 'speed-boost'], 'base_experience': 52, 'height': 4, 'id': 543, 'moves': ['take-down', 'double-edge', 'poison-sting', 'twineedle', 'pin-missile', 'solar-beam', 'toxic', 'agility', 'screech', 'double-team', 'defense-curl', 'rest', 'substitute', 'snore', 'protect', 'sludge-bomb', 'spikes', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'endeavor', 'secret-power', 'signal-beam', 'iron-defense', 'poison-tail', 'gyro-ball', 'payback', 'toxic-spikes', 'poison-jab', 'rock-climb', 'bug-bite', 'venoshock', 'round', 'struggle-bug', 'steamroller', 'confide', 'venom-drench', 'infestation'], 'name': 'venipede', 'stats': {'hp': 30, 'attack': 45, 'defense': 59, 'special-attack': 30, 'special-defense': 39, 'speed': 57}, 'types': ['bug', 'poison'], 'weight': 53, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'フシデ', 'ko': '마디네', 'zh-Hant': '百足蜈蚣', 'fr': 'Venipatte', 'de': 'Toxiped', 'es': 'Venipede', 'it': 'Venipede', 'en': 'Venipede', 'ja': 'フシデ', 'zh-Hans': '百足蜈蚣'}, 'genera': {'ja-Hrkt': 'ムカデポケモン', 'ko': '지네포켓몬', 'zh-Hant': '蜈蚣寶可夢', 'fr': 'Pokémon Chilopode', 'de': 'Tausendfüßer', 'es': 'Pokémon Ciempiés', 'it': 'Pokémon Centipede', 'en': 'Centipede Pokémon', 'ja': 'ムカデポケモン', 'zh-Hans': '蜈蚣宝可梦'}}
	public class SpecieVenipede : PokemonSpecie
	{
#nullable enable
		private static SpecieVenipede? _instance = null;
#nullable restore
        public static SpecieVenipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenipede();
                }
                return _instance;
            }
        }

		public SpecieVenipede() : base(
			"Venipede",
			30, // HPs
			45, 59, // Attack & Defense
			30, 39, // Special Attack & Defense
			57			
		) {}
	}


	//Venipede Pokemon Class
	public class Venipede : Pokemon
	{

		public Venipede(string nickname, int level) : base(
			543,
			SpecieVenipede.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Poison.Instance			
		) {}

		public Venipede() : base(
			543,
			SpecieVenipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}