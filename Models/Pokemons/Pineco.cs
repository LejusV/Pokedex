using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pineco Specie to store common natural stats of every {'abilities': ['sturdy', 'overcoat'], 'base_experience': 58, 'height': 6, 'id': 204, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'pin-missile', 'counter', 'strength', 'solar-beam', 'string-shot', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'self-destruct', 'swift', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'spikes', 'sandstorm', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'rapid-spin', 'sweet-scent', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'revenge', 'secret-power', 'rock-tomb', 'sand-tomb', 'iron-defense', 'gravity', 'gyro-ball', 'natural-gift', 'payback', 'power-trick', 'toxic-spikes', 'captivate', 'stealth-rock', 'bug-bite', 'venoshock', 'round', 'struggle-bug', 'bulldoze', 'drill-run', 'confide'], 'name': 'pineco', 'stats': {'hp': 50, 'attack': 65, 'defense': 90, 'special-attack': 35, 'special-defense': 35, 'speed': 15}, 'types': ['bug'], 'weight': 72, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'gray', 'shape': 'ball', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'クヌギダマ', 'roomaji': 'Kunugidama', 'ko': '피콘', 'zh-Hant': '榛果球', 'fr': 'Pomdepik', 'de': 'Tannza', 'es': 'Pineco', 'it': 'Pineco', 'en': 'Pineco', 'ja': 'クヌギダマ', 'zh-Hans': '榛果球'}, 'genera': {'ja-Hrkt': 'みのむしポケモン', 'ko': '도롱이벌레포켓몬', 'zh-Hant': '蓑衣蟲寶可夢', 'fr': 'Pokémon Ver Caché', 'de': 'Beutelwurm', 'es': 'Pokémon Larva', 'it': 'Pokémon Larva', 'en': 'Bagworm Pokémon', 'ja': 'みのむしポケモン', 'zh-Hans': '蓑衣虫宝可梦'}}
	public class SpeciePineco : PokemonSpecie
	{
#nullable enable
		private static SpeciePineco? _instance = null;
#nullable restore
        public static SpeciePineco Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePineco();
                }
                return _instance;
            }
        }

		public SpeciePineco() : base(
			"Pineco",
			50, // HPs
			65, 90, // Attack & Defense
			35, 35, // Special Attack & Defense
			15			
		) {}
	}


	//Pineco Pokemon Class
	public class Pineco : Pokemon
	{

		public Pineco(string nickname, int level) : base(
			204,
			SpeciePineco.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Pineco() : base(
			204,
			SpeciePineco.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}